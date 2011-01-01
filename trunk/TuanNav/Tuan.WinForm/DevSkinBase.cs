using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace Tuan.WinForm
{
    public partial class DevSkinBase : XtraForm
    {
        public DefaultLookAndFeel _DefaultLookAndFeel;
        public DevSkinBase()
        {
            InitializeComponent();

            _DefaultLookAndFeel = new DefaultLookAndFeel(); 
            LoadSkin();
        }
        private void LoadSkin()
        {
            if (Config.SystemConfig.Instance != null && Config.SystemConfig.Instance.SkinName != _DefaultLookAndFeel.LookAndFeel.SkinName)
            {
                _DefaultLookAndFeel.LookAndFeel.SkinName = Config.SystemConfig.Instance.SkinName;
            }
        }
    }
}
