using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tuan.Common;
using Tuan.Config;
using Tuan.Entity;
using Tuan.Entity.Config;
using Tuan.Data.DAO;

namespace Tuan.Web
{
    public partial class index : Tuan.Web.UI.BasePage
    {
        protected string newTuan;
        protected string recommend;

        protected void Page_Load(object sender, EventArgs e)
        {
            //从缓存中获取指定城市ID的首页团购推荐
            recommend = CacheAccess.Get<string>("IndexRecommend_" + cityId);
            if (string.IsNullOrEmpty(recommend))
            {
                recommend = GetRecommend();
            }

            //从缓存中获取指定城市ID的首页团购列表
            newTuan = CacheAccess.Get<string>("IndexTuanList_" + cityId);
            if (string.IsNullOrEmpty(newTuan))
            {
                newTuan = GetTuanList(0, 0, 0, null, true);
            }
        }

        /// <summary>
        /// Ajax获取指定城市团购列表
        /// </summary>
        private void GetTuanListAjax()
        {
            int lp = Utils.GetQueryInt("lp");
            int hp = Utils.GetQueryInt("hp");
            string order = Utils.GetQueryString("order");
            bool desc = bool.Parse(Utils.GetQueryString("desc"));
            int category = Utils.GetQueryInt("category");
            cityId = Utils.GetQueryInt("cityID");

            string tuanList = GetTuanList(category, lp, hp, order, desc);
            Ajax.Write(tuanList);
        }

        /// <summary>
        /// 获取指定城市推荐团购
        /// </summary>
        private string GetRecommend()
        {
            ModelList tuanList = TuanGouDAO.Instance.GetRecommend(cityId);

            if (tuanList != null && tuanList.Count > 0)
            {
                StringBuffer main = new StringBuffer();
                StringBuffer list = new StringBuffer();
                main += "<div class=\"main\">";
                list += "<div class=\"list\">";

                for (int i = 0; i < tuanList.Count; i++)
                {
                    ///////////////// 团购详情
                    if (i == 0)
                        main += "<table width=\"100%\" height=\"100%\" cellspacing=\"6\"><tr><td colspan=\"2\" height=\"30\"><h3><a href=\"";
                    else
                        main += "<table style=\"display:none;\" width=\"100%\" height=\"100%\" cellspacing=\"6\"><tr><td colspan=\"2\" height=\"30\"><h3><a href=\"";
                    main += tuanList[i]["SiteUrl"];
                    main += "\" target=\"_blank\">【";
                    main += tuanList[i]["SiteName"];
                    main += "】</a><a href=\"";
                    main += tuanList[i]["TuanUrl"];
                    main += "\" target=\"_blank\">";
                    main += tuanList[i]["Title"].Length >32 ? tuanList[i]["Title"].Substring(0, 32) : tuanList[i]["Title"];
                    main += "</a></h3></td></tr><tr><td width=\"240\"><dl class=\"meta\"><dt class=\"price\">原 价</dt><dt class=\"rebate\">折 扣</dt><dt class=\"save\">节 省</dt><dd class=\"price\"><code>￥</code>";
                    main += tuanList[i]["MarketPrice"];
                    main += "</dd><dd class=\"rebate\">";
                    main += tuanList[i]["Rebate"];
                    main += "</dd><dd class=\"save\"><code>￥</code>";
                    main += tuanList[i]["TuanPrice"];
                    main += "</dd></dl></td><td rowspan=\"4\" width=\"260\" height=\"204\" align=\"center\"><img src=\"";
                    main += tuanList[i]["ImageUrl"];
                    main += "\" height=\"198\" width=\"240\" /></td></tr><tr><td class=\"nums\"><p>共有 <strong>";
                    main += tuanList[i]["BuyCount"];
                    main += "</strong> 人购买</p><p>评论：";
                    main += tuanList[i]["CommentCount"];
                    main += " &nbsp; 观点：";
                    main += tuanList[i]["PointCount"];
                    main += "</p></td></tr><tr><td class=\"timer\"><p>剩余时间: </p><div></div></td></tr><tr><td class=\"buy\"><p><code>￥</code>";
                    main += tuanList[i]["TuanPrice"];
                    main += "</p></td></tr></table>";

                    ///////////////// 团购列表
                    list += "<dl><dt><img src=\"";
                    list += tuanList[i]["ImageUrl"];
                    list += "\" width=\"73\" height=\"73\" /></dt><dd class=\"tprice\">现 价:<span><code>￥</code>";
                    list += tuanList[i]["TuanPrice"];
                    list += "</span></dd><dd class=\"price\">原 价:<span><code>￥</code>";
                    list += tuanList[i]["MarketPrice"];
                    list += "</span></dd><dd class=\"info\">";
                    list += tuanList[i]["Description"];
                    list += "</dd></dl>";
                }
                main += "</div>";
                list += "</div>";
                return main.ToString() + list.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取指定城市团购列表
        /// </summary>
        private string GetTuanList(int category, int lp, int hp, string order, bool desc)
        {
            ModelList tuanList = TuanGouDAO.Instance.GetNewTuan(cityId, category, lp, hp, order, desc);

            if (tuanList != null && tuanList.Count > 0)
            {
                StringBuffer buffer = new StringBuffer();
                for (int i = 0; i < tuanList.Count; i++)
                {
                    buffer += "<div class=\"detail\"><img src=\"";
                    buffer += tuanList[i]["ImageUrl"];
                    buffer += "\" /><div class=\"head\"><a href=\"";
                    buffer += tuanList[i]["SiteUrl"];
                    buffer += "\" target=\"_blank\">【";
                    buffer += tuanList[i]["SiteName"];
                    buffer += "】</a><h5><a href=\"";
                    buffer += tuanList[i]["TuanUrl"];
                    buffer += "\" title=\"";
                    buffer += tuanList[i]["Title"];
                    buffer += "\" target=\"_blank\">";
                    buffer += tuanList[i]["Title"];
                    buffer += "</a></h5></div><dl class=\"meta\"><dt>团购价:</dt><dd class=\"tprice\"><code>￥</code>";
                    buffer += tuanList[i]["TuanPrice"];
                    buffer += "</dd><dt>折扣:</dt><dd class=\"rebate\">";
                    buffer += tuanList[i]["Rebate"];
                    buffer += "折</dd></dl><dl class=\"meta\"><dt>原价:</dt><dd class=\"price\"><code>￥</code>";
                    buffer += tuanList[i]["MarketPrice"];
                    buffer += "</dd></dl><dl class=\"meta\"><dt>售出:</dt><dd class=\"sale\">";
                    buffer += tuanList[i]["BuyCount"];
                    buffer += "件</dd></dl><dl class=\"meta\"><dd class=\"talk\"><a href=\"#\" title=\"查看评论\">(";
                    buffer += tuanList[i]["CommentCount"];
                    buffer += ")</a></dd><dd class=\"point\"><a href=\"#\" title=\"查看观点\">(";
                    buffer += tuanList[i]["PointCount"];
                    buffer += ")</a></dd></dl><button onclick=\"window.open('";
                    buffer += tuanList[i]["TuanUrl"];
                    buffer += "')\">立即购买</button></div> ";
                }
                return buffer.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
