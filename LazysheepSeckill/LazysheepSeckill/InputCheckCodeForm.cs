using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using Config;
using Utils;
using System.IO;

namespace LazysheepSeckill
{
    public partial class InputCheckCodeForm : Form
    {
        public InputCheckCodeForm()
        {
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

            pic_CheckCode.ImageLocation = "https://regcheckcode.taobao.com/auction/checkcode?sessionID=2b2b8f048540ce4cecf511e5ee155379";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tbx_CheckCode.Text.Length == 4)
            {
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
                this.Close();
            }
        }

        private void pic_CheckCode_Click(object sender, EventArgs e)
        {
            LoadCheckCodeImage();
        }
    }
}
