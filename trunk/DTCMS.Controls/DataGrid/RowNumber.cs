//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-03-01 17:46:26
// 功能描述: DataGrid Control
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
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
    public class RowNumber : ItemBase
    {
        private bool _visible;
        private bool _increase;
        private string _width;
        private string _headerText = "ID";
        private string _sortField;

        /// <summary>
        /// 是否显示选择框
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("是否显示数据行索引")]
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        /// <summary>
        /// 是否自增序列
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("是否自增序列")]
        public bool Increase
        {
            get { return _increase; }
            set { _increase = value; }
        }

        /// <summary>
        /// 列宽度
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("列宽度")]
        public new string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 列名
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("列名")]
        public string HeaderText
        {
            get { return _headerText; }
            set { _headerText = value; }
        }

        /// <summary>
        /// 单击表头排序字段
        /// </summary>
        [NotifyParentProperty(true)]
        [Description("单击表头排序字段")]
        public string SortField
        {
            get { return _sortField; }
            set { _sortField = value; }
        }
    }
}