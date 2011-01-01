using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tuan.WinForm
{
    public partial class TuanMainForm : DevSkinBase
    {
        public TuanMainForm()
        {
            InitializeComponent();
        }

        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                string formTypeName = ((DevExpress.XtraNavBar.NavBarItem)(sender)).Tag.ToString().Trim();
                Form frmChild = (Form)Activator.CreateInstance(null, formTypeName).Unwrap();
                if (frmChild != null)
                {
                    Form tempForm = Activate(frmChild);
                    if (tempForm == null)
                    {
                        frmChild.MdiParent = this;
                        frmChild.Show();
                    }
                }
            }
            catch { }
        }
        private Form Activate(Form form)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    form.Activate();
                    return form;
                }
            }
            return null;
        }
    }
}
