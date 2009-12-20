using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace DTCMS.Common
{
    public enum MessageIcon
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success,

        /// <summary>
        /// 错误
        /// </summary>
        Error,

        /// <summary>
        /// 警告
        /// </summary>
        Warning,

        /// <summary>
        /// 停止
        /// </summary>
        Stop,

        /// <summary>
        /// 问号
        /// </summary>
        Question,

        /// <summary>
        /// 信息
        /// </summary>
        Information
    }

    public class Message
    {
        /// <summary>
        /// 页面提示信息方法
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="url">链接地址</param>
        /// <param name="icon">提示图标</param>
        public static void Dialog(string message, string url, MessageIcon icon)
        {
            Dialog("DTCMS提示信息", message, url, icon, 3);
        }

        public static void Dialog(string message, string url, MessageIcon icon, int time)
        {
            Dialog("DTCMS提示信息", message, url, icon, time);
        }

        /// <summary>
        /// 页面提示信息方法
        /// </summary>
        /// <param name="title">提示标题</param>
        /// <param name="message">消息内容</param>
        /// <param name="url">链接地址</param>
        /// <param name="icon">提示图标</param>
        /// <param name="time">自动跳转时间（0为不自动跳转）</param>
        public static void Dialog(string title, string message, string url, MessageIcon icon, int time)
        {
            HttpContext.Current.Response.ContentType = "text/html";
            HttpContext.Current.Response.AddHeader("Content-Type", "text/html");
            StringBuilder sb = new StringBuilder();

            sb.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n");
            sb.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            sb.Append("<head>\r\n");
            sb.Append("<title>" + title + "</title>\r\n");
            sb.Append("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n");
            if (time > 0)
                sb.Append("<meta http-equiv='refresh' content='" + time + "; url=" + (url == "-1" ? "javascript:history.go(-1)" : url) + "' />\r\n");
            sb.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"/inc/dialog/dialog.css\" />\r\n");
            sb.Append("</head>\r\n");
            sb.Append("<body>\r\n");
            sb.Append("<table id=\"dialog\" class=\"dialog_blue\">\r\n");
            sb.Append("<tr class=\"dialog_header\" align=\"right\"><td class=\"h_l\"></td><td class=\"h_c\"><h2>" + title + "</h2>\r\n");
            sb.Append("<a href=\"javascript:window.close()\" class=\"close\"></a></td>\r\n");
            sb.Append("<td class=\"h_r\"></td></tr>\r\n");
            sb.Append("<tr class=\"dialog_content\">\r\n");
            sb.Append("<td class=\"c_l\"></td>\r\n");
            sb.Append("<td class=\"c_c\">\r\n");
            sb.Append("<div class=\"icon " + icon.ToString() + "\"></div>\r\n");
            sb.Append("<div class=\"message\">" + message + "</div>\r\n");
            sb.Append("<div style=\"clear:left\"></div>\r\n");
            if (time > 0)
                sb.Append("<div class=\"buttonRow\"><a href=\"" + (url == "-1" ? "javascript:history.go(-1)" : url) + "\">如果页面没有自动跳转，请点击这里...</a></div>\r\n");
            else if (url == "-1")
                sb.Append("<div class=\"buttonRow\"><a href=\"javascript:history.go(-1);\">点击这里返回上一级操作</a></div>\r\n");
            else
                sb.Append("<div class=\"buttonRow\"><a href=\"" + url + "\">请点击这里进行下一步操作...</a></div>\r\n");
            sb.Append("</td>\r\n");
            sb.Append("<td class=\"c_r\"></td>\r\n");
            sb.Append("</tr>\r\n");
            sb.Append("<tr class=\"dialog_bottom\"><td class=\"b_l\"></td><td class=\"b_c\"></td><td class=\"b_r\"></td></tr>\r\n");
            sb.Append("</table>\r\n</body>\r\n</html>\r\n");

            HttpContext.Current.Response.Write(sb.ToString());
            HttpContext.Current.Response.End();
        }
    }
}
