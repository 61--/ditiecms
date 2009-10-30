using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Common
{
    /// <summary>
    /// ��Ϣ�Ի���ͨ���࣬������̳л�ʵ����
    /// </summary>
    public sealed class Message
    {
        private Message()
        {
            //˽�й��캯����������ʵ����
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
            System.Web.HttpContext.Current.Response.Write("<li><a href=\"/\">������ҳ</a></li>");
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
        /// ��ʾ��Ϣ��ʾ�Ի���
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        public static void ShowMessage(System.Web.UI.Page page, string msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>alert('" + msg.ToString() + "');</script>");
        }

        /// <summary>
        /// �ؼ���� ��Ϣȷ����ʾ��
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            //Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }

        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>alert('" + msg + "');window.location=\"" + url + "\"</script>");
        }

        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
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
        /// ����Զ���ű���Ϣ
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="script">����ű�</param>
        public static void ResponseScript(System.Web.UI.Page page, string script)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script type='text/javascript'>" + script + "</script>");

        }

    }
}
