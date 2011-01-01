using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tuan.WinForm
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

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            Config.SystemConfig.ReadConfig();

            Application.Run(new TuanMainForm());
        }
    }
}
