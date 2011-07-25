using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LazysheepSeckill
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            
            SplashScreen splash = new SplashScreen();
            splash.Show();

            Application.Run(new MainForm(splash));
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs ex)
        {

        }
    }
}
