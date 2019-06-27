using LOG;
using System;

using System.Windows.Forms;

namespace testWPF
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            LOG.LOG.log("exception", ReasonForLog.EXCEPTION);
            LOG.LOG.log(ReasonForLog.HANDLED);
            LOG.LOG.LogToExcel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
