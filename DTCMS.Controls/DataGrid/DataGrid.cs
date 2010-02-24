using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class DataGrid : WebControl
    {
        #region DataGrid属性

        private string _id = null;
        private string _bindDataMethod = null;
        private bool _isPage;
        private int _pageSize;
        private string _cssClass;

        /// <summary>
        /// 控件ID
        /// </summary>
        [Description("控件ID")]
        [Browsable(true), DefaultValue((string) null)]
        public override string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 绑定数据客户端Ajax方法
        /// </summary>
        [Description("绑定数据客户端Ajax方法")]
        [Browsable(true), DefaultValue((string)null)]
        public string BindDataMethod
        {
            get { return _bindDataMethod; }
            set { _bindDataMethod = value; }
        }

        /// <summary>
        /// 数据列是否分页
        /// </summary>
        [Description("数据列是否分页")]
        [Browsable(true), DefaultValue(true)]
        public bool IsPage
        {
            get { return _isPage; }
            set { _isPage = value; }
        }

        /// <summary>
        /// 数据列分页大小
        /// </summary>
        [Description("数据列分页大小")]
        [Browsable(true), DefaultValue(20)]
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 应用于该控件的CSS类名
        /// </summary>
        [Description("应用于该控件的CSS类名")]
        [Browsable(true), DefaultValue((string)null)]
        public override string CssClass
        {
            get { return _cssClass; }
            set { _cssClass = value; }
        }
        #endregion

        protected override void Render(HtmlTextWriter output)
        {
            output.WriteLine(string.Format("<table id=\"{0}\" class=\"{1}\">", ID, CssClass));
            output.WriteLine("</table>");
            output.WriteLine(IsPage);
            output.WriteLine(PageSize);
            output.WriteLine(CssClass);
            //base.Render(output);
        }
    }
}
