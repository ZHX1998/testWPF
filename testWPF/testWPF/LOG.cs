using System;
using System.IO;
using System.Data;

namespace LOG
{
    #region 记录日志时的原因
    /*
       *在使用LOG.long()方法时，对应其中的等级。
       *START对应启动软件，FIRED对应发生火情，
       *HANDLED对应情况已处理，CLOSE对应关闭软件，EXCEPTION对应软件异常
        */
    public class ReasonForLog
    {
        public static int START = 0;
        public static int FIRED = 1;
        public static int HANDLED = 2;
        public static int CLOSE = 3;
        public static int EXCEPTION = 4;
    }

    #endregion

    public class LOG
    {
        static FileIO fio;

        #region 日志信息
        private enum LogMessage
        {
            应用程序启动 = 0,
            程序判断起火 = 1,
            操作人员已经处理 = 2,
            应用程序关闭 = 3,
            应用程序异常 = 4,
            该异常由其他部分声明

        }
        #endregion

        static LOG()
        {
            //获取今天的日期，并创建相应的log文件
            string date = DateTime.Now.ToLongDateString().ToString();
            fio = new FileIO();
            fio.OpenWriteFile("logfiles/" + date + ".txt");
        }

        #region 写日志
        /*
               *log()接收log消息，并将写入文件中
                */
        public static void log(string str, int level)//string类型日志和loglevel输入
        {
            if (str == null)
            {
                str = "null";
            }
            fio.WriteLine(DateTime.Now.ToLocalTime() + " " + str + (LogMessage)level + "\n");
        }
        public static void log(object p, int level)//其他部分定义的异常和level输入
        {
            log(p.ToString(), level);
        }
        public static void log(object str)//其他部分定义的异常输入
        {
            log(str, 5);
        }
        public static void log(int level)//level输入
        {
            fio.WriteLine(DateTime.Now.ToLocalTime() + " " + (LogMessage)level + "\n");
        }
        #endregion
        static object syn = new object();

        #region 写入excel
        /**
               *将本月份的txt日志文件转换为xls文件，默认为当前月份
                */
        public static void LogToExcel(string datetime)
        {
            #region 创建自定义的DataTable
            //创建DataTable
            string[] columNames = { "日期", "时间", "情况说明" };
            CreateDataTable cdt = new CreateDataTable();
            cdt.SetDataTable(columNames);
            DataTable dt = cdt.GetDataTable();
            #endregion

            #region 获取txt日志文件
            if (datetime == null)
            {
                datetime = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月";
            }
            string[] files = GetFiles(datetime);//获取所需月份的文件

            #endregion


            #region 写入日志到DataTable

            DataRow dr;
            for (int i = 0; i < files.Length; i++) //遍历文件
            {
                if (files[i] == null) break;

                FileIO readFile = new FileIO();
                readFile.OpenReadFile(files[i]);

                while (!readFile.IsEof())
                {     //文件结束，跳出循环
                    string strings = readFile.ReadLine(); //按行读取文件

                    if (!strings.Equals(""))
                    {
                        string[] split = strings.Split(' ');
                        //将每一行写入到对应的列下
                        dr = dt.NewRow();
                        dr["日期"] = split[0];
                        dr["时间"] = split[1];
                        dr["情况说明"] = split[2];

                        dt.Rows.Add(dr);
                    }
                }
            }

            #endregion
            //写入excel文件中
            Excel.Excel.CreateExcel(dt, "logfiles/"+datetime + ".xls");
        }
        public static void LogToExcel()
        {
            LogToExcel(null);
        }

        #endregion

        /*创建自定义的DataTable格式 */
        private class CreateDataTable
        {
            private DataTable dt;

            public CreateDataTable()
            {
                dt = new DataTable();
            }

            public void SetDataTable(String[] columNames)
            {

                foreach (var name in columNames)
                {
                    DataColumn dc = new DataColumn(name, Type.GetType("System.String"));
                    dt.Columns.Add(dc);
                }
            }
            public DataTable GetDataTable()
            {
                return dt;
            }
        }
        /*
         * 按年月获取文本格式的日志文件
         */
        private static string[] GetFiles(string datetime)
        {
            string[] files = Directory.GetFiles("logfiles", datetime + "*.txt");
            return files;
        }
    }
    public class FileIO
    {
        #region 创建文件读写流
        private FileStream fsr;
        private FileStream fsw;
        private StreamWriter sw;
        private StreamReader sr;
        #endregion

        #region 读取文件
        //打开文件
        public void OpenReadFile(string file)
        {
            if (!File.Exists(file))
                File.Create(file).Close();
            fsr = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fsr);
        }

        //读取文件的一行
        public string ReadLine()
        {
            if (sr.EndOfStream)  // 如果文件流指针已经指向文件尾部，返回null
                return null;
            return sr.ReadLine();
        }

        //关闭读文件流
        public void CloseReadFile()
        {
            if (fsr != null)
                fsr.Close();
        }
        #endregion

        #region 写文件
        // 创建用于向文件中追加行的文件流和StreamWriter对象
        public void OpenWriteFile(string file)
        {
            if (!File.Exists(file))  // 如果文件不存在，先创建这个文件
                File.Create(file).Close();
            // 以追加模式打开这个文件
            fsw = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            // 根据创建的FileStream对象来创建StreamWriter对象
            sw = new StreamWriter(fsw);
        }

        // 向文件中追加一行字符串
        public void WriteLine(string s)
        {
            lock (sw)
            {
                sw.WriteLine(s);
                sw.Flush(); // 刷新写入缓冲区，使这一行对于读文件流可见
            }
        }

        // 关闭写文件流
        public void CloseWriteFile()
        {
            if (fsw != null)
                fsw.Close();
        }
        #endregion
        public void Clear()
        {
            CloseWriteFile();
        }

        // 用于判断文件流指针是否位于文件尾部
        public bool IsEof()
        {
            return sr.EndOfStream;
        }
    }
}
