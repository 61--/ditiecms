using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class CheckBox
    {
        private bool _visible;
        private string _width;

        /// <summary>
        /// 是否显示选择框
        /// </summary>
        [Description("是否显示选择框")]
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        /// 列宽度
        /// </summary>
        [Description("列宽度")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}
