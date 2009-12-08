using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using DTCMS.Entity;
using DTCMS.Common;

namespace DTCMS.Web.admin.news
{
    public partial class News_add : System.Web.UI.Page
    {
        private Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();
        private int NewID = 0;  //文章ID

        protected void Page_Load(object sender, EventArgs e)
        {
            NewID = Common.Utils.GetQueryInt("Id");

            if (!IsPostBack)
            {
                if (NewID > 0)
                {
                    SetPageData();  //更新数据赋值
                }
            }
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            int n = 0;  //更新是否成功

            if (NewID > 0)
            {
                n = bllArticle.Update(GetArticleModel());

                if (n > 0)
                {
                    Message.Dialog("更新文章成功！", "News_list.aspx", MessageIcon.Success, 0);
                }
                else if (n == -3)
                {
                    Message.Dialog("添加文章失败！该文章已经存在。", "Class_list.aspx", MessageIcon.Error, 0);
                }
                else
                {
                    Message.Dialog("更新文章失败！请检查数据是否完整。", "News_list.aspx", MessageIcon.Success, 0);
                }

            }
            else
            {
                n = bllArticle.Add(GetArticleModel());

                if (n > 0)
                {
                    Message.Dialog("添加文章成功！", "News_list.aspx", MessageIcon.Success, 0);
                }
                else if (n == -3)
                {
                    Message.Dialog("添加文章失败！该文章已经存在。", "News_list.aspx", MessageIcon.Error, 0);
                }
                else
                {
                    Message.Dialog("添加文章失败！请检查数据是否完整。", "News_list.aspx", MessageIcon.Success, 0);
                }
            }
        }

        /// <summary>
        ///  更新，初始化页面数据
        /// </summary>
        /// <param name="NewID">文章ID</param>
        private void SetPageData()
        {
            if (NewID <= 0)
            {
                return;
            }

             Arc_Article model = bllArticle.GetModel(NewID);

             if (model != null)
             {
                 slt_TitleFlag.Value = model.TitleFlag.HasValue ? model.TitleFlag.ToString() : "0";
                 txt_Title.Value = model.Title;
                 hide_Attribute.Value = model.Attribute;
                 hide_TitleStyle.Value = model.TitleStyle;
                 txt_Tags.Value = model.Tags;
                 txt_ClassID.Value = model.ClassID.ToString();  //栏目ID
                 txt_Source.Value = model.Source;
                 txt_Author.Value = model.Author;
                 txt_Editor.Value = model.Editor;
                 txt_ImageUrl.Value = model.ImgUrl;
                 if (model.IsPaging.HasValue)   //是否分页
                 {
                     rdo_Autopage.Checked = (model.IsPaging == 0);
                 }
                 txt_Content.Value = model.Content;
                 txt_ShortTitle.Value = model.ShortTitle.Trim();
                 txt_ViceClassID.Value = model.ViceClassID.ToString();
                 txt_OrderID.Value = model.OrderID.HasValue ? model.OrderID.Value.ToString() : "0";
                 txt_Templet.Value = model.Templet;
                 txt_FilePath.Value = model.FilePath;
                 txt_PubDate.Value = model.PubDate.ToString();
                 slt_Readaccess.Value = model.Readaccess.ToString();
                 txt_Money.Value = model.Money.HasValue ? model.Money.Value.ToString() : "0";
                 txt_SimilarArticle.Value = model.SimilarArticle;
                 txt_Keywords.Value = model.Keywords.Trim();
                 txt_Description.Value = model.Description;

                 if (model.IsHtml.HasValue)  //是否生成静态页
                 {
                     chk_IsHtml.Checked = (model.IsHtml == 1);
                 }
                 if (model.IsComment.HasValue)   //是否评论
                 {
                     chk_IsComment.Checked = (model.IsComment == 1);
                 }
                 
                 chk_IsChecked.Checked = (model.IsChecked == 1); //是否审核             
             }
        }
        /// <summary>
        /// 获取文章实体，添加，修改
        /// </summary>
        /// <returns>文章实体</returns>
        private Arc_Article GetArticleModel()
        {
            Arc_Article model = new Arc_Article();

            model.ID = NewID;
            if (slt_TitleFlag.Value.Trim() == "")
            {
                model.TitleFlag = null;
            }
            else
            {
                model.TitleFlag = int.Parse(slt_TitleFlag.Value.Trim());
            }
            model.TitleStyle = hide_TitleStyle.Value.Trim();
            model.Title = txt_Title.Value.Trim();
            model.Attribute = hide_Attribute.Value.Trim();  //文章属性
            model.Tags = txt_Tags.Value.Trim();
            model.ClassID = int.Parse(txt_ClassID.Value.Trim() == "" ? "0" : txt_ClassID.Value.Trim());
            model.Source = txt_Source.Value.Trim();
            model.Author = txt_Author.Value.Trim();
            model.Editor = txt_Editor.Value.Trim();
            model.ImgUrl = txt_ImageUrl.Value.Trim();
            model.IsPaging = rdo_Autopage.Checked ? 1 : 0;
            model.Content = txt_Content.Value.Trim();
            model.ShortTitle = txt_ShortTitle.Value.Trim();
            if (txt_ViceClassID.Value.Trim() == "")
            {
                model.ViceClassID = null;
            }
            else
            {
                model.ViceClassID = int.Parse(txt_ViceClassID.Value.Trim());
            }
            if (txt_OrderID.Value.Trim() == "")
            {
                model.OrderID = null;
            }
            model.OrderID = int.Parse(txt_OrderID.Value.Trim());
            model.Templet = txt_Templet.Value.Trim();
            model.FilePath = txt_FilePath.Value.Trim();
            model.PubDate = Convert.ToDateTime(txt_PubDate.Value.Trim() == "" ? DateTime.Now.ToString("yyyy-MM-dd HH:ss:mm") : txt_PubDate.Value.Trim());
            if (slt_Readaccess.Value.Trim() == "")
            {
                model.Readaccess = null;
            }
            else
            {
                model.Readaccess = int.Parse(slt_Readaccess.Value.Trim());
            }
            model.Money = int.Parse(txt_Money.Value.Trim() == "" ? "0" : txt_Money.Value.Trim());
            model.SimilarArticle = txt_SimilarArticle.Value.Trim();
            model.Keywords = txt_Keywords.Value.Trim();
            model.Description = txt_Description.Value.Trim();
            model.IsHtml = chk_IsHtml.Checked ? 1 : 0;
            model.IsComment = chk_IsComment.Checked ? 1 : 0;
            model.IsChecked = chk_IsChecked.Checked ? 1 : 0;
            model.AddDate =Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            return model;
        }
    }
}
