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

namespace DTCMS.Web.admin.news
{
    public partial class News_add : System.Web.UI.Page
    {
        Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void SetPageData()
        {
             if (CID <= 0)
            {
                return;
            }

            Arc_Article model = bllClass.GetModel(CID);

            if (model != null)
            {
                slt_TitleFlag.Value = model.TitleFlag;
                txt_Title.Value = model.Title;
                hide_Attribute.Value = model.Attribute;
                txt_Tags.Value = model.Tags;
                txt_ClassID.Value = model.ClassID.ToString();
                txt_Source.Value = model.Source;
                txt_Author.Value = model.Author;
                txtEditor.Value = model.Editor;
                txt_ImageUrl.Value = model.ImgUrl;
                if (model.IsPaging.HasValue)
                {
                    if (model.IsPaging == 0)
                        rdo_Autopage.Checked = true;
                    else
                        rdo_Manualpage.Checked = true;
                }
                txt_Content.Value = model.Content;
                txt_ShortTitle.Value = model.ShortTitle.Trim();
                txt_OrderID.Value=model.OrderID.HasValue?model.OrderID.Value.ToString():"0";
                txt_Templet.Value=model.Templet;
                txt_FilePath.Value=model.FilePath;
                txt_PubDate.Value=model.PubDate.ToString();model.
                txt_Money.Value=model.Money.HasValue?model.Money.Value.ToString():"0";
                txt_SimilarArticle.Value = model.SimilarArticle;
                txt_Keywords.Value = model.Keywords.Trim();
                txt_Description.Value = model.Description;

                if (model.IsHtml.HasValue)//是否生成静态页
                {
                    if(model.IsHtml==1)
                        chk_IsHtml.Checked=true;
                    else
                        chk_IsHtml.Checked=false;
                }
                if(model.IsComment.HasValue)//是否评论
                {
                    if(model.IsComment==1)
                        chk_IsComment.Checked=true;
                    else
                        chk_IsComment.Checked=false;
                }
                if(model.IsChecked.HasValue)//是否审核
                {
                    if (model.IsChecked == 1)
                        chk_IsChecked.Checked=true;
                    else
                        chk_IsChecked.Checked=false;
                }
                
                    
            }
        }
        private Arc_Article GetArticleModel(int Id)
        {
            Arc_Article model = bllArticle.GetModel(Id);
            return model;
            //model.i
        }
    }
}
