﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.BLL;

namespace DTCMS.Web.admin.ajax
{
    public partial class news_list : System.Web.UI.Page
    {
        private Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();   //文章

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            switch (action)
            {
                case "load": 
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// 创建文章表格
        /// </summary>
        public string CreateArticleTable()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> table = new Dictionary<string, string>();
            return sb.ToString();
        }
    }
}