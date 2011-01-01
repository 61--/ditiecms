using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tuan.WinForm
{
    public partial class SettingForm : DevSkinBase
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            textEdit_localDB.Text = Config.SystemConfig.Instance.LocalDBConn;
            textEdit_serverDB.Text = Config.SystemConfig.Instance.ServerDBConn;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Config.SystemConfig.Instance.LocalDBConn = textEdit_localDB.Text.Trim();
            Config.SystemConfig.Instance.ServerDBConn = textEdit_serverDB.Text.Trim();
            Config.SystemConfig.WriteConfig(Config.SystemConfig.Instance);
            DevExpress.XtraEditors.XtraMessageBox.Show("配置已更新!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
