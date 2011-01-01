using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Data;
using Tuan.Common;
using Tuan.Data.DAO;

namespace Tuan.Web.js
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class site_json : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var siteJson = string.Empty;

            if (context.Cache["siteJson"] == null)
            {
                DataTable dt = TuanSiteDAO.Instance.GetSiteByCityID(0);

                StringBuilder json = new StringBuilder();
                json.Append("var siteJson = [");

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        json.AppendFormat("{{siteid:'{0}',", dt.Rows[i]["SiteID"]);
                        json.AppendFormat("sitename:'{0}',", dt.Rows[i]["SiteName"]);
                        json.AppendFormat("spell:'{0}'}}", Utils.GetChineseSpell(dt.Rows[i]["SiteName"].ToString()).ToLower());
                        json.Append(",");
                    }
                    json.Remove(json.Length - 1, 1);
                }
                json.Append("];");
                siteJson = json.ToString();
            }
            else
            {
                siteJson = context.Cache["siteJson"].ToString();
            }

            context.Response.ContentType = "text/javascript";
            context.Response.Charset = "utf-8";
            context.Response.Write(siteJson);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
