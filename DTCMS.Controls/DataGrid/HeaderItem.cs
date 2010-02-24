using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    /// <summary>
    /// 表头列集合
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [PersistenceMode(PersistenceMode.InnerProperty)]
    public class HeaderItem
    {
        private string _text;
        private string _align;
        private string _width;
        private string _cssClass;
        private bool _isSort;

        /// <summary>
        /// 表头文本
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// 对齐方式
        /// </summary>
        public string Align
        {
            get { return _align; }
            set { _align = value; }
        }

        /// <summary>
        /// 列宽度
        /// </summary>
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 表头的CSS类名
        /// </summary>
        public string CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }

        /// <summary>
        /// 单击表头是否排序
        /// </summary>
        public bool IsSort
        {
            get { return _isSort; }
            set { _isSort = value; }
        }
    }
}
