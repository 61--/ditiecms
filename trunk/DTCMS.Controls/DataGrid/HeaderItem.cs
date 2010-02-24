using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class HeaderItem
    {
        private string _title;
        private string _align;
        private string _width;
        private string _cssClass;
        private bool _isOrder;

        /// <summary>
        /// 表头文本
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
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
        public bool IsOrder
        {
            get { return _isOrder; }
            set { _isOrder = value; }
        }
    }
}
