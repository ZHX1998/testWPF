using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Data;
using System.IO;
using System;

namespace Excel
{
    public class Excel
    {
        private DataTable dt = new DataTable();

        public static void CreateExcel(DataTable dt, string path)
        {
            #region 创建sheet
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(dt.TableName);//创建工作表
            sheet.SetColumnWidth(4, 100 * 256);
            #endregion

            #region 标题
            IRow row = sheet.CreateRow(0);//在工作表中添加一行
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = row.CreateCell(i);//在行中添加一列
                cell.SetCellValue(dt.Columns[i].ColumnName);//设置列的内容 

            }
            #endregion

            #region 填充数据
            for (int i = 1; i <= dt.Rows.Count; i++)//遍历DataTable行
            {
                DataRow dataRow = dt.Rows[i - 1];
                row = sheet.CreateRow(i);//在工作表中添加一行

                for (int j = 0; j < dt.Columns.Count; j++)//遍历DataTable列
                {
                    ICell cell = row.CreateCell(j);//在行中添加一列
                    cell.SetCellValue(dataRow[j].ToString());//设置列的内容     
                }
            }
            #endregion

            #region 写入到Excel
            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);

            try
            {
                using (var fout = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    byte[] bArr = ms.ToArray();
                    fout.Write(bArr, 0, bArr.Length);
                    fout.Flush();
                    fout.Close();
                }
                #endregion
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}