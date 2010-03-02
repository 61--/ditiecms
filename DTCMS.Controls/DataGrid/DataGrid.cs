using System;
using System.Text;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: TagPrefix("DTCMS.Controls", "DT")]
namespace DTCMS.Controls
{
    /// <summary>
    /// DataGrid 服务器控件
    /// </summary>
    [ToolboxData("<{0}:DataGrid CssClass='table_data' runat='server'></{0}:DataGrid>")]
    [DefaultProperty("Text")]
    public class DataGrid : WebControl, INamingContainer
    {
        #region DataGrid属性

        private string _id;
        private string _bindAjaxMethod;
        private bool _isPage = true;
        private int _pageSize = 15;
        private string _cssClass;
        private ColumnCollection _columns;

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
        /// 创建 ColumnItem 控件容器
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("要在控件中显示的一组列")]
        public ColumnCollection Colunms
        {
            get
            {
                if (_columns == null)
                {
                    _columns = new ColumnCollection();
                }
                return _columns;
            }
        }
        #endregion

        //重写Render方法
        protected override void Render(HtmlTextWriter output)
        {
            //构造Table标签
            output.AddAttribute(HtmlTextWriterAttribute.Id, this.ID);
            if (this.CssClass != null)
            {
                output.AddAttribute(HtmlTextWriterAttribute.Class, this.CssClass);
            }
            output.RenderBeginTag(HtmlTextWriterTag.Table);

            //构造Tr标签
            output.AddAttribute(HtmlTextWriterAttribute.Class, "thead");
            output.RenderBeginTag(HtmlTextWriterTag.Tr);

            for (int i = 0; i < Colunms.Count; i++)
            {
                if (Colunms[i].GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)this.Colunms[i];
                    //是否显示CheckBox
                    if (checkBox.Visible)
                    {
                        if (checkBox.Width != null)
                        {
                            output.AddAttribute(HtmlTextWriterAttribute.Width, checkBox.Width);
                        }
                        output.RenderBeginTag(HtmlTextWriterTag.Td);

                        output.AddAttribute(HtmlTextWriterAttribute.Type, "checkbox");
                        output.AddAttribute(HtmlTextWriterAttribute.Onclick, "invertCheckBox(this)");
                        output.RenderBeginTag(HtmlTextWriterTag.Input);
                        output.RenderEndTag();
                        output.RenderEndTag();
                    }
                }
                else if (Colunms[i].GetType() == typeof(RowsIndex))
                {
                    RowsIndex rowsIndex = (RowsIndex)this.Colunms[i];
                    //是否显示数据行索引
                    if (rowsIndex.Visible)
                    {
                        if (rowsIndex.Width != null)
                        {
                            output.AddAttribute(HtmlTextWriterAttribute.Width, rowsIndex.Width);
                        }
                        output.RenderBeginTag(HtmlTextWriterTag.Td);
                        output.Write(rowsIndex.HeaderText);
                        output.RenderEndTag();
                    }
                }
                else
                {
                    //构造表头集合
                    ColumnItem columnItem = (ColumnItem)this.Colunms[i];
                    if (columnItem.Width != null)
                    {
                        output.AddAttribute(HtmlTextWriterAttribute.Width, columnItem.Width);
                    }
                    if (columnItem.CssClass != null)
                    {
                        output.AddAttribute(HtmlTextWriterAttribute.Class, columnItem.CssClass);
                    }
                    output.RenderBeginTag(HtmlTextWriterTag.Td);

                    //如果排序字段不为空，则添加客户端排序方法
                    if (columnItem.IsSort)
                    {
                        output.AddAttribute(HtmlTextWriterAttribute.Id, columnItem.DataField);
                        output.AddAttribute(HtmlTextWriterAttribute.Href, "javascript:;");
                        output.AddAttribute(HtmlTextWriterAttribute.Title, "点击排序列");
                        output.AddAttribute(HtmlTextWriterAttribute.Onclick, "onSortClick(this);");
                        output.RenderBeginTag(HtmlTextWriterTag.A);
                        output.Write(columnItem.HeaderText);

                        //生成排序图标
                        output.AddAttribute(HtmlTextWriterAttribute.Id, string.Format("{0}_SortType", columnItem.DataField));
                        output.RenderBeginTag(HtmlTextWriterTag.Span);
                        output.RenderEndTag();

                        output.RenderEndTag();
                    }
                    else
                    {
                        output.Write(columnItem.HeaderText);
                    }
                    output.RenderEndTag();
                }
            }
            //构造Tbody标签
            output.AddAttribute(HtmlTextWriterAttribute.Id, "dataList");
            output.RenderBeginTag(HtmlTextWriterTag.Tbody);
            output.RenderEndTag();

            output.RenderEndTag();
            output.RenderEndTag();

            output.WriteLine();
            output.WriteLine(BuildJavaScript());
        }

        /// <summary>
        /// 创建Javascript脚本
        /// </summary>
        /// <returns></returns>
        private string BuildJavaScript()
        {
            StringBuilder js = new StringBuilder();
            js.Append("<script type=\"text/javascript\">\r\n");
            js.Append("$(function(){showLoading();loadData();hideMessage();});\r\n");
            if (this.IsPage)
            {
                js.Append("function loadData(page){");
                js.Append("page=page||1;");
            }
            else
            {
                js.Append("function loadData(){");
            }
            js.Append("var callback=function(res){");
            js.Append("if(res.error){");
            js.Append("alert(\"请求错误，请刷新页面重试！\\n\"+res.error.Message);return;}");
            js.Append("showDataList(res.value);};");
            js.Append(this.BindAjaxMethod);
            js.Append(this.IsPage ? "(page,callback);}" : "(callback);}");
            js.Append("\r\n</script>");


            return js.ToString();
        }
    }
}
