using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LazysheepSeckill
{
    public partial class frmSplash : Form,ISplashForm
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        #region ISplashForm

        void ISplashForm.SetStatusInfo(string NewStatusInfo)
        {
            lbStatusInfo.Text = NewStatusInfo;
        }

        #endregion

        /*
        private void LoadConfig()
        {
            Splasher.Status = "正在初始化程序...";
            InitializeData();
            skin.SkinFile = @"Skins\MacOS.ssk";
            Control.CheckForIllegalCrossThreadCalls = false;
            Splasher.Status = "初始化完毕...";
            Splasher.Close();
        }

        private void InitializeData()
        {
            AppConfigInfo config = ConfigAccess<AppConfigInfo>.GetConfig();
            if (config != null)
            {
                tbx_UserName.Text = config.UserName;
                tbx_PassWord.Text = SecurityUtils.DesDecode(config.PassWord);
                tbx_goodsUrl.Text = config.GoodsUrl;
            }
        }
        */
        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}