using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: TagPrefix("DTCMS.Controls", "DT")]
namespace DTCMS.Controls
{
    /// <summary>
    /// DataGrid 服务器控件
    /// http://blog.csdn.net/ChengKing/archive/2009/01/01/3678774.aspx
    /// </summary>
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:DataGrid CssClass='table_data' runat='server'></{0}:DataGrid>")]
    public class DataGrid : WebControl
    {
        #region DataGrid属性

        private string _id;
        private bool _isCheckBox;
        private bool _isListIndex;
        private string _bindAjaxMethod;
        private bool _isPage;
        private int _pageSize;
        private string _cssClass;

        private HeaderItemCollection _columns;
        //private HeaderItemCollection _headerItem;

        /// <summary>
        /// 控件ID
        /// </summary>
        [DefaultValue("")]
        [Description("控件ID")]
        public override string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 是否显示选择框
        /// </summary>
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("是否显示选择框")]
        public bool IsCheckBox
        {
            get { return _isCheckBox; }
            set { _isCheckBox = value; }
        }

        /// <summary>
        /// 是否显示数据列索引序号
        /// </summary>
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("是否显示数据列索引序号")]
        public bool IsListIndex
        {
            get { return _isListIndex; }
            set { _isListIndex = value; }
        }

        /// <summary>
        /// 绑定数据客户端Ajax方法
        /// </summary>
        [DefaultValue("")]
        [Description("客户端绑定数据Ajax方法")]
        public string BindAjaxMethod
        {
            get { return _bindAjaxMethod; }
            set { _bindAjaxMethod = value; }
        }

        /// <summary>
        /// 数据列是否分页
        /// </summary>
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("数据列是否分页")]
        public bool IsPage
        {
            get { return _isPage; }
            set { _isPage = value; }
        }

        /// <summary>
        /// 数据列分页大小
        /// </summary>
        [DefaultValue(15)]
        [Category("Behavior")]
        [Description("数据列分页大小")]
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 应用于该控件的CSS类名
        /// </summary>
        [DefaultValue("")]
        [Category("Behavior")]
        [Description("应用于该控件的CSS类名")]
        public override string CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }

        /// <summary>
        /// 创建 HeaderItem 控件容器
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("要在控件中显示的一组列")]
        public HeaderItemCollection Colunms
        {
            get
            {
                if (_columns == null)
                {
                    _columns = new HeaderItemCollection();
                }
                return _columns;
            }
        }

        ///// <summary>
        ///// 表头集合
        ///// </summary>
        //[PersistenceMode(PersistenceMode.Attribute)] 
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //public HeaderItemCollection HeaderItem
        //{
        //    get { return _headerItem; }
        //}
        #endregion

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.WriteLine(string.Format("<table id=\"{0}\" class=\"{1}\">", ID, CssClass));
            output.WriteLine("</table>");
            output.WriteLine(IsPage);
            output.WriteLine(PageSize);
            output.WriteLine(CssClass);
            output.WriteLine(IsCheckBox);
            output.WriteLine(IsListIndex);
            output.WriteLine(BindAjaxMethod);
        }
    }
}
