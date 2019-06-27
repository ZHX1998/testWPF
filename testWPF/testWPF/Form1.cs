using AForge.Video;
using AForge.Video.FFMPEG;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace testWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            /*蜂鸣器线程*/
            Thread thread1 = new Thread(delegate () {//新建一个线程，用来控制蜂鸣器响或者不响
                while (true)
                {
                    while (warning)
                    {
                        Beep(500, 700);
                        Thread.Sleep(200);
                    }
                }
            });
            thread1.Start();
            thread1.IsBackground = true;//主窗口关闭后，关闭后台进程
            /*--------------------------------*/
        }

        /*窗体高度和宽度*/
        private float width;
        private float heigth;

        /*录像部分变量*/
        private Camera camera;
        private VideoFileWriter writer;
        private Boolean isRecord = false;
        private Boolean isRun = false;
        private string filename = "";
        //定义Timer 
        System.Timers.Timer Timers_Timer = new System.Timers.Timer();

        /*报警蜂鸣器变量*/
        public bool warning = false; //将警报初值设为false
        [DllImport("Kernel32.dll")] //引入命名空间 using System.Runtime.InteropServices;
        public static extern bool Beep(int frequency, int duration);   //定义调用蜂鸣器的函数


        private void Form1_Load(object sender, EventArgs e)
        {
            width = this.Width;
            heigth = this.Height;
            Utils.setTag(this);
            /*---------------------*/
            /*设备的加载*/
            camera = new Camera();
            writer = new VideoFileWriter();
            videoSourcePlayer1.VideoSource = camera.getCamera();//设置视频player的源
            Console.WriteLine("相机和视频加载完毕");
            camera.getCamera().NewFrame += new NewFrameEventHandler(writeVideo);//new frame的注册函数
            camera.Start();
            videoSourcePlayer1.Start();
            Console.WriteLine("相机和视频启动完毕");
            startVideo();
            Console.WriteLine("开始生成视频文件");
            /*--------------------*/
           

        }
        /*写入视频文件*/
        private void writeVideo(Object o, NewFrameEventArgs e)
        {
            if (writer.IsOpen && isRecord)
            {
                Bitmap bitmap = e.Frame;
                writer.WriteVideoFrame(bitmap);
                bitmap.Dispose();
            }
        }

        private void startVideo()
        {
            if (this.camera.isRun()&&videoSourcePlayer1.IsRunning)
            {
                isRun = true;
                filename = DateTime.Now.ToString("yyyy-mm-dd-hh-mm-ss-ff") + ".avi";
                writer.Open(@"c:\users\administrator\desktop\test\" + filename,
                    camera.getWidth(),
                    camera.getHeight(),
                    camera.getFrameRate(),
                    VideoCodec.MPEG4);
                isRecord = true;
            }
            else
            {
                MessageBox.Show("无法找到视频源");
            }
            /*启动计时器*/
            Timers_Timer.Interval = 30 * 1000;
            Timers_Timer.Enabled = true;
            Timers_Timer.Start();
            Timers_Timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
        }

        /*计时器定时执行的函数*/
        protected void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            isRecord = false;
            Thread.Sleep(1000);
            if (writer.IsOpen)
            {
                writer.Close();
            }
            if (isRun)
            {
                const string dir = @"C:\Users\Administrator\Desktop\test\";
                if (!File.Exists(dir))
                    Directory.CreateDirectory(dir);

                //覆盖上一次的录屏文件
                //if (File.Exists(dir + filename))
                //    File.Delete(dir + filename);

                filename = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".avi";
                writer.Open(@"C:\Users\Administrator\Desktop\test\" + filename,
                   camera.getWidth(),
                   camera.getHeight(),
                   camera.getFrameRate(),
                   VideoCodec.MPEG4);
                isRecord = true;
            }
            else
            {
                MessageBox.Show("无法找到视频源");
            }

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush Brush = new SolidBrush(Color.Black);//单色画刷 
            RectangleF TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);//绘制区域
            
            StringFormat sf = new StringFormat();//封装文本布局格式信息 
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, Brush, TabTextArea,sf);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float ratioX = (this.Width) / width;
            float ratioY = (this.Height) / heigth;
            Utils.setControl(ratioX, ratioY, this);
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 创见打开对话框对象实例
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //设置为可以打开多个文件
            openFileDialog.Multiselect = true;

            //设置打开文件格式
            openFileDialog.Filter = "Avi文件|*.avi|Mp3文件|*.mp3|Wav文件|*.wav|Wma文件|*.wma|Wmv文件|*.wmv|所有格式|*.*";

            //判断是否单击确定按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                //建立播放列表，名字为aa
                //mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("aa", "");
               

                //遍历打开的集合
                foreach (string fn in openFileDialog.FileNames)
                {
                    //添加播放列表
                    //MediaPlayer3.currentPlaylist.appendItem(MediaPlayer3.newMedia(fn));
                    listBox1.Items.Add(fn);
                }
            }
            //播放
            //MediaPlayer3.Ctlcontrols.play();
            // MediaPlayer3.settings.autoStart = false;
        }


        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabpages_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (warning == true)
            {
                warning = false;
                OpenBuzz.Text = "打开";//显示当前警报状态,能接入信号后，新建线程监听异常
                label3.Text = "false";
            }
            else
            {
                warning = true;
                OpenBuzz.Text = "关闭";
                label3.Text = "true";
            }
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {
            
        }

        private void media_play_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }

        private void media_pause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        private void media_stop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            if (selected >= 0)
            {
                string filename = listBox1.Items[selected].ToString();
                mediaPlayer.URL = filename;
                mediaPlayer.Ctlcontrols.play();
            }
            
        }
    }
}
