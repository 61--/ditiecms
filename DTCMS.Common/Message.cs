using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace DTCMS.Common
{
    public enum MessageIcon
    {
        /// <summary>
        /// 错误
        /// </summary>
        Error = 1,

        /// <summary>
        /// 警告
        /// </summary>
        Warning = 2,

        /// <summary>
        /// 停止
        /// </summary>
        Stop = 3,

        /// <summary>
        /// 问号
        /// </summary>
        Question = 4,

        /// <summary>
        /// 信息
        /// </summary>
        Information = 5
    }

    public class Message
    {
        /// <summary>
        /// 页面提示信息方法
        /// </summary>
        /// <param name="title">提示标题</param>
        /// <param name="message">消息内容</param>
        /// <param name="links">链接</param>
        /// <param name="autojump">是否自动跳转</param>
        /// <param name="showback">是否返回</param>
        public static void Show(string title, string message, string url, MessageIcon icon, int time)
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
            sb.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"/css/message.css\" />\r\n");
            sb.Append("</head>\r\n");
            sb.Append("<body>\r\n");
            sb.Append("<div id=\"container\">\r\n");
            sb.Append("<div id=\"title\"><h1>" + title + "</h1></div>\r\n");
            sb.Append("<div id=\"content\">\r\n");
            sb.Append(message);
            sb.Append(MessageIcon.Stop);
            if (time > 0)
                sb.Append("<div class=\"bottom\"><a href=\"" + (url == "-1" ? "javascript:history.go(-1)" : url) + "\">如果页面没有自动跳转，请点击这里...</a></div>\r\n");
            else if (url == "-1")
                sb.Append("<div class=\"bottom\"><a href=\"javascript:history.go(-1);\">点击这里返回上一级操作</a></div>\r\n");
            else
                sb.Append("<div class=\"bottom\"><a href=\"" + url + "\">请点击这里进行下一步操作...</a></div>\r\n");
            sb.Append("</div>\r\n");
            sb.Append("</div>\r\n");
            sb.Append("</body>\r\n");
            sb.Append("</html>\r\n");

            HttpContext.Current.Response.Write(sb.ToString());
            HttpContext.Current.Response.End();
        }
    }
}
