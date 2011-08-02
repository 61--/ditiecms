using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Config;
using Utils;
using System.IO;

namespace Core
{
    public partial class CheckCodeForm : Form
    {
        private string m_CheckCodeUrl;
        public string CheckCode;

        public CheckCodeForm(string checkCodeUrl)
        {
            this.m_CheckCodeUrl = checkCodeUrl;

            InitializeComponent();
            LoadCheckCodeImage();
        }

        private void LoadCheckCodeImage()
        {
            //HttpUtils http = new HttpUtils();
            //http.Method = "GET";
            //Stream stream = http.Request("https://regcheckcode.taobao.com/auction/checkcode?sessionID=2b2b8f048540ce4cecf511e5ee155379").GetResponseStream();

            //Image checkcodeImage = Image.FromStream(stream);
            //pic_CheckCode.Image = checkcodeImage;

            pic_CheckCode.ImageLocation = m_CheckCodeUrl;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tbx_CheckCode.Text.Length == 4)
            {
                CheckCode = tbx_CheckCode.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_ErrInfo.ForeColor = System.Drawing.Color.Red;
                lbl_ErrInfo.Text = "  验证码输入错误！";
            }
        }

        private void tbx_CheckCode_TextChanged(object sender, EventArgs e)
        {
            if (cbx_AutoSubmit.Checked && tbx_CheckCode.Text.Length == 4)
            {
                CheckCode = tbx_CheckCode.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pic_CheckCode_Click(object sender, EventArgs e)
        {
            LoadCheckCodeImage();
        }
    }
}
