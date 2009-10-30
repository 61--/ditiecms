using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Common
{
    /// <summary>
    /// 消息对话框通用类，不允许继承或实例化
    /// </summary>
    public sealed class Message
    {
        private Message()
        {
            //私有构造函数，不允许实例化
        }

        public static void ShowMessage(string title, string msg)
        {
            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Write("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head><title>");
            System.Web.HttpContext.Current.Response.Write(title);
            System.Web.HttpContext.Current.Response.Write(" - Powered by 91aspx.com</title><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
            System.Web.HttpContext.Current.Response.Write("<link rel=\"stylesheet\" type=\"text/css\" href=\"msgbox.css\" />");
            System.Web.HttpContext.Current.Response.Write("</head>");
            System.Web.HttpContext.Current.Response.Write("<body>");
            System.Web.HttpContext.Current.Response.Write("<div id=\"container\">");
            System.Web.HttpContext.Current.Response.Write("<div id=\"header\">");
            System.Web.HttpContext.Current.Response.Write("<ul>");
            System.Web.HttpContext.Current.Response.Write("<li class=\"select\">");
            System.Web.HttpContext.Current.Response.Write(title);
            System.Web.HttpContext.Current.Response.Write("</li>");
            System.Web.HttpContext.Current.Response.Write("<li><a href=\"/\">返回首页</a></li>");
            System.Web.HttpContext.Current.Response.Write("</ul>");
            System.Web.HttpContext.Current.Response.Write("</div>");
            System.Web.HttpContext.Current.Response.Write("<div id=\"messagebox\">");
            System.Web.HttpContext.Current.Response.Write("<div id=\"message\">");
            System.Web.HttpContext.Current.Response.Write(msg);
            System.Web.HttpContext.Current.Response.Write("</div>");
            System.Web.HttpContext.Current.Response.Write("</div>");
            System.Web.HttpContext.Current.Response.Write("</div>");
            System.Web.HttpContext.Current.Response.Write("</body>");
            System.Web.HttpContext.Current.Response.Write("</html>");
            System.Web.HttpContext.Current.Response.End();
        }

        /// <summary>
        /// 显示消息提示对话框
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void ShowMessage(System.Web.UI.Page page, string msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>alert('" + msg.ToString() + "');</script>");
        }

        /// <summary>
        /// 控件点击 消息确认提示框
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            //Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }

        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>alert('" + msg + "');window.location=\"" + url + "\"</script>");
        }

        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowAndRedirects(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script type='text/javascript'>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", Builder.ToString());

        }

        /// <summary>
        /// 输出自定义脚本信息
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="script">输出脚本</param>
        public static void ResponseScript(System.Web.UI.Page page, string script)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>" + script + "</script>");

        }

    }
}
