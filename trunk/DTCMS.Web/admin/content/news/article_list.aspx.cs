using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class article_list : AdminPage
    {
        private Arc_ArticleBLL articleBll = new Arc_ArticleBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(article_list));
        }

        #region Ajax 方法
        /// <summary>
        /// 获取文章Json数据
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetArticleJsonData(int currentPage)
        {
            return articleBll.GetArticleJsonData(currentPage);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        [AjaxPro.AjaxMethod]
        public int DeleteArticle(string id)
        {
            try
            {
                if (id == "")
                {
                    return -1;
                }
                return articleBll.Delete(id);
            }
            catch
            {
                return -2;
            }
        }

        /// <summary>
        /// 审核文章
        /// </summary>
        [AjaxPro.AjaxMethod]
        public int VerifyArticle(string id)
        {
            return 1;
        }
        #endregion
    }
}
