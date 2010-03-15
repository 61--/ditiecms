using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    [ToolboxItem(false)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CheckBox : ItemBase
    {
        private string _dataField;
        private bool _visible;
        private string _width;

        /// <summary>
        /// 绑定字段
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("绑定字段")]
        public string DataField
        {
            get { return _dataField; }
            set { _dataField = value; }
        }

        /// <summary>
        /// 是否显示选择框
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("是否显示选择框")]
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        /// 列宽度
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("列宽度")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}
