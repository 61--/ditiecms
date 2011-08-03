using System;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using Utils;

namespace Core
{
    public class TaobaoCore : ICore
    {
        private string m_ErrorMsg;
        private bool m_NeedCheckCode = false;
        private HttpUtils http = new HttpUtils();

        public bool Login(string userName, string passWord)
        {
            string html = string.Empty;
            string loginUrl = "https://login.taobao.com/member/login.jhtml";
            http.Method = "GET";

            html = http.RequestUrl("https://login.taobao.com");
            html = html.Substring(0, html.IndexOf("</form>")).Substring(html.IndexOf("<form id=\"J_StaticForm\""));

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            HtmlNodeCollection inputNodes = doc.DocumentNode.SelectNodes("//input[@type='hidden']");
            if (inputNodes == null)
            {
                m_ErrorMsg = "未知错误，请检查网络是否正常后重试。";
                return false;
            }

            StringBuffer postData = new StringBuffer();
            foreach (HtmlNode node in inputNodes)
            {
                postData += string.Format("{0}={1}&", node.Attributes["name"].Value, node.Attributes["value"] == null ? "" : node.Attributes["value"].Value);
            }
            http.AddPostKey(postData.ToString());
            http.AddPostKey("TPL_username", userName);
            http.AddPostKey("TPL_password", passWord);

            string need_check_code = doc.DocumentNode.SelectSingleNode("//input[@name='need_check_code']").Attributes["value"].Value;
            if (m_NeedCheckCode || need_check_code.Length > 0)
            {
                string checkCodeUrl = doc.GetElementbyId("J_StandardCode_m").Attributes["data-src"].Value;
                CheckCodeForm ccForm = new CheckCodeForm(checkCodeUrl);
                if (ccForm.ShowDialog() != DialogResult.OK)
                {
                    m_ErrorMsg = "请输入验证码!";
                    return false;
                }
                string checkCode = ccForm.CheckCode;

                http.AddPostKey("TPL_checkcode", checkCode);
                http.EditPostKey("need_check_code", "true");
            }
            else
            {
                http.AddPostKey("TPL_checkcode", string.Empty);
                http.EditPostKey("need_check_code", string.Empty);
            }

            http.Method = "POST";
            http.Location = true;
            html = http.RequestUrl(loginUrl);

            if (http.Error)
            {
                m_ErrorMsg = http.ErrorMsg;
                return false;
            }
            else
            {
                if (html.IndexOf("window.location = \"http") > 0)
                {
                    return true;
                }
                else if (html.IndexOf("验证码错误") > 0)
                {
                    m_ErrorMsg = "验证码错误，请重新输入。";
                    m_NeedCheckCode = true;
                    return false;
                }
                else if (html.IndexOf("请输入验证码") > 0)
                {
                    m_ErrorMsg = "请输入验证码后再登录！";
                    m_NeedCheckCode = true;
                    return false;
                }
                else if (html.IndexOf("密码和账户名不匹配") > 0 || html.IndexOf("该账户名不存在") > 0)
                {
                    m_ErrorMsg = "登录用户名或密码错误！";
                    return false;
                }
                else
                {
                    m_ErrorMsg = "未知错误，请重新登录！";
                    return false;
                }
            }
        }

        public GoodsEntity GetGoodsInfo(string goodsUrl)
        {
            string html = string.Empty;
            http.Method = "GET";
            html = http.RequestUrl(goodsUrl);
            int start = html.IndexOf("<div id=\"detail\" class=\"tshop-psm tb-box\">");
            if (start > 0)
            {
                int end = html.IndexOf("<div id=\"description\" class=\"tshop-psm ke-post J_DetailSection\">");
                html = html.Substring(0, end).Substring(start);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                GoodsEntity goods = new GoodsEntity();
                goods.Title = doc.DocumentNode.SelectSingleNode("//input[@name='title']").Attributes["value"].Value;
                goods.Price = TryConvert.ToDouble(doc.DocumentNode.SelectSingleNode("//input[@name='current_price']").Attributes["value"].Value);
                goods.Stock = TryConvert.ToInt32(doc.DocumentNode.SelectSingleNode("//input[@name='allow_quantity']").Attributes["value"].Value);
                goods.Status = doc.GetElementbyId("J_LinkBuy").InnerText;
                return goods;
            }
            else
            {
                return null;
            }
        }

        public string ErrorMsg
        {
            get { return m_ErrorMsg; }
        }

        public CookieCollection Cookies
        {
            get { return http.Cookies; }
        }
    }
}
