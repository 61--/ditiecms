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
    /// ColumnItem 成员属性
    /// </summary>
    public class ColumnItem
    {
        private string _headerText;
        private string _dataField;
        private string _align;
        private string _width;
        private string _cssClass;
        private bool _isSort;

        /// <summary>
        /// 列名
        /// </summary>
        public string HeaderText
        {
            get { return _headerText; }
            set { _headerText = value; }
        }

        /// <summary>
        /// 绑定字段
        /// </summary>
        public string DataField
        {
            get { return _dataField; }
            set { _dataField = value; }
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
