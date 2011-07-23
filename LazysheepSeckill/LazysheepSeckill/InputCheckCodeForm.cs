using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LazysheepSeckill
{
    public partial class InputCheckCodeForm : Form
    {
        public InputCheckCodeForm()
        {
            InitializeComponent();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("输入正确");
        }
    }
}
