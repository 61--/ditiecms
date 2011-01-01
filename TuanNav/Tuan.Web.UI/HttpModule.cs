using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Tuan.Common;
using Tuan.Config;
using Tuan.Entity.Config;
using System.Text.RegularExpressions;

namespace Tuan.Web.UI
{
    public class HttpModule : System.Web.IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(UrlRewrite_BeginRequest);
        }

        /// <summary>
        /// Url 地址重写
        /// </summary>
        public void UrlRewrite_BeginRequest(object sender, EventArgs e)
        {
            HttpContext context = ((HttpApplication)sender).Context;
            string requestPath = context.Request.Path.ToLower();

            string appPath = ConfigAccess<AppConfigInfo>.GetConfig().AppPath;
            if (requestPath.StartsWith(appPath))
            {
                requestPath = requestPath.Substring(appPath.Length);
                if (requestPath.IndexOf("/") == -1) //访问路径在网站根目录下
                {
                    return;
                }
                else
                {
                    if (requestPath.StartsWith("admin/") || requestPath.StartsWith("user/"))
                    {
                        return;
                    }
                    if (requestPath.EndsWith("index.aspx") || requestPath.EndsWith("/"))
                    {
                        string query = requestPath.Substring(0, requestPath.IndexOf("/"));
                        context.RewritePath(appPath + "index.aspx?city=" + query);
                        return;
                    }
                    else
                    {
                        UrlRewriteInfo urls = ConfigAccess<UrlRewriteInfo>.GetConfig();
                        foreach (UrlRewrite url in urls.UrlRewrite)
                        {
                            if (Regex.IsMatch(requestPath, url.Pattern, RegexOptions.None))
                            {
                                string query = Regex.Replace(requestPath, url.Pattern, url.QueryString, RegexOptions.None);

                                context.RewritePath(appPath + url.Page, string.Empty, string.Concat(query, "&", context.Request.QueryString));
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
