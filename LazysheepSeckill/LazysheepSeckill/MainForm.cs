using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;
using Config;
using Utils;

namespace LazysheepSeckill
{
    public partial class MainForm : Form
    {
        string strServer = string.Empty;
        string strPath = string.Empty;
        HttpUtils http = new HttpUtils();

        public MainForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            AppConfigInfo config = ConfigAccess<AppConfigInfo>.GetConfig();
            if (config != null)
            {
                tbx_UserName.Text = config.UserName;
                tbx_PassWord.Text = SecurityUtils.DesDecode(config.PassWord);
                tbx_goodsUrl.Text = config.GoodsUrl;
            }
        }

        private void btn_LoginTaobao_Click(object sender, EventArgs e)
        {
            string html = string.Empty;
            string loginUrl = "http://login.taobao.com/member/login.jhtml";
            http.Method = "GET";
            html = http.RequestToHtml(loginUrl);
            html = html.Substring(0, html.IndexOf("</form>")).Substring(html.IndexOf("<form id=\"J_StaticForm\""));

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            HtmlNodeCollection inputNodes = doc.DocumentNode.SelectNodes("//input[@type='hidden']");
            if (inputNodes == null)
            {
                MessageBox.Show("未知错误，请检查网络连接后重试。");
                return;
            }

            StringBuffer postData = new StringBuffer();
            foreach (HtmlNode node in inputNodes)
            {
                postData += string.Format("{0}={1}&", node.Attributes["name"].Value, node.Attributes["value"] == null ? "" : node.Attributes["value"].Value);
            }
            http.AddPostKey(postData.ToString());
            http.AddPostKey("TPL_username", tbx_UserName.Text);
            http.AddPostKey("TPL_password", tbx_PassWord.Text);
            //http.EditPostKey("loginType", "3");
            http.Method = "POST";
            html = http.RequestToHtml(loginUrl);

            if (http.Error)
            {
                MessageBox.Show(http.ErrorMsg);
            }
            else
            {
                if (html.IndexOf("请输入验证码") > 0)
                {
                    new InputCheckCodeForm().Show();
                    return;
                }
                else if (html.IndexOf("您输入的密码和账户名不匹配")>0)
                {
                    MessageBox.Show("登录用户名或密码错误。");
                    return;
                }
                else
                {
                    MessageBox.Show("登录成功。");
                }
                //MessageBox.Show(html);
            }
        }

        private void btn_openGoods_Click(object sender, EventArgs e)
        {
            string goodsUrl = tbx_goodsUrl.Text.Trim();
            if (string.IsNullOrEmpty(goodsUrl))
            {
                MessageBox.Show("请输入商品地址。");
                return;
            }
            string html = string.Empty;
            http.Method = "GET";
            html = http.RequestToHtml(goodsUrl);
            if (http.Error)
            {
                MessageBox.Show(http.ErrorMsg);
            }
            else
            {
                MessageBox.Show(html);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //string u = this.txtUserName.Text.Trim();
            //string p = this.txtPwd.Text.Trim();
            //DateTime st = DateTime.Now;

            //淘宝登录需要post的数据串
            //string sendData = "TPL_username=" + u + "&TPL_password=" + Server.UrlEncode(p) + "&actionForStable=enable_post_user_action&action=Authenticator&mi_uid=&mcheck=&TPL_redirect_url=http%3A%2F%2Fitem.taobao.com%2Fauction%2Fitem_detail-0db1-3036113cf5455bd74047f1a581ba4be7.htm&_oooo_=http%3A%2F%2Fitem.taobao.com%2Fauction%2Fitem_detail-0db1-3036113cf5455bd74047f1a581ba4be7.htm&event_submit_do_login=anything&abtest=&pstrong=3&from=&yparam=&done=&loginType=3&tid=&support=000001&CtrlVersion=1%2C0%2C0%2C7";

            //string s = GetHtml("login.taobao.com", "/member/login.jhtml", "post", sendData, "");
            //Session["Cookies"] = GetCookies(s); //从返回的源码中提取cookies，抓取登录后的页面需要附上该cookies 

        }
        protected void btnBuy_Click(object sender, EventArgs e)
        {
            //string strURL = this.txtURL.Text.Trim();
            //getServerAndPath(strURL);

            //string s = GetHtml(strServer, strPath, "get", "", Session["Cookies"].ToString());
            ////Response.Write(s);
            //if (s.IndexOf("立即购买") > 0)
            //{
            //    string item_id = strURL.Split('-')[2].Split('.')[0].ToString();
            //    string x_id = strURL.Split('-')[1].ToString();

            //    s = GetHtml("buy.taobao.com", "/auction/buy.htm?from=itemDetail&item_id=" + item_id + "&x_id=" + x_id, "get", "", Session["Cookies"].ToString());
            //    //Response.Write(s);
            //    using (StreamWriter sw = new StreamWriter(Server.MapPath("debug1.html")))
            //    {
            //        sw.Write(s);
            //    }

            //    if (s.IndexOf("确认提交订单") > 0)
            //    {
            //        Session["Cookies"] = GetCookies(s);
            //        string postData = getPostData(s);
            //        string r = GetHtml("buy.taobao.com", "/auction/buy_now.htm", "post", postData, Session["Cookies"].ToString());
            //        if (r.IndexOf("302") > 0)
            //        {
            //            using (StreamWriter sw = new StreamWriter(Server.MapPath("debug2.html")))
            //            {
            //                sw.Write(r);
            //            }
            //        }
            //        else
            //        {
            //            ////
            //        }
            //        using (StreamWriter sw = new StreamWriter(Server.MapPath("debug2.html")))
            //        {
            //            sw.Write(r);
            //        }
            //    }
            //}
            //else if (s.IndexOf("btn-wait") > 0)//该宝贝还处于定时上架的状态
            //{

            //}

        }


        /// <summary>
        /// 从返回的源代码中提取cookies
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string GetCookies(string s)
        {
            StringBuilder sbCookies = new StringBuilder();

            string[] arr = s.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in arr)
            {
                if (str.StartsWith("Set-Cookie: "))
                {
                    int intStart = str.IndexOf(";");
                    string strCookie = str.Substring(12, intStart - 11);
                    sbCookies.Append(strCookie);
                }
            }
            return sbCookies.ToString();
        }

        private string GetLocationURL(string s)
        {

            string RtnString = string.Empty;
            StringBuilder sbCookies = new StringBuilder();

            string[] arr = s.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in arr)
            {
                if (str.StartsWith("Location: "))
                {
                    RtnString = str.Substring(11, str.Length - 11);
                }
            }
            return RtnString;
        }



        private void getServerAndPath(string strURL)
        {
            if (strURL != "" && strURL.IndexOf("/") > 0)
            {
                int SlashPos = strURL.Substring(7).IndexOf("/");
                strServer = strURL.Substring(7, SlashPos);
                strPath = strURL.Substring(SlashPos + 7);
            }
            else
                return;
        }



        /// <summary>
        /// 从最后确认购买页面的源代码中提取表单数据的数据
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private string getPostData(string html)
        {
            string postStr = "";
            string pat = "<input .*?name.{0,1}=.{0,1}\"(.*?)\".*? value.{0,1}=\"(.*?)\".*?>";
            Regex regex = new Regex(pat, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            MatchCollection mcollection = regex.Matches(html);

            foreach (Match m in mcollection)
            {
                GroupCollection gcollection = m.Groups;
                if (m.ToString().IndexOf("_fma.b._0.s") > 0) { continue; }
                if (m.ToString().IndexOf("_fma.b._0.c") > 0) { continue; }
                if (m.ToString().IndexOf("isCheckCode") > 0 && gcollection[2].Value.ToLower() == "true")
                {
                    //isCheckCode = true;
                }
                postStr += gcollection[1].Value; postStr += "=";
                //postStr += Server.UrlEncode(gcollection[2].Value);
                postStr += "&";
            }
            postStr += "n_prov=370000&n_city=370500&n_area=370522&_fma.b._0.w=quicky&_fma.b._0.ac=250&consignment=10&_fma.b._0.au=5&_fma.b._0.c=8888";
            //postStr = postStr.Replace("quantity=0", "quantity=1").Replace("_fma.b._0.d=您不必重复省-市-区信息；至少5个字", "_fma.b._0.d=" + Server.UrlEncode("收货人的具体地址")).Replace("_fma.b._0.po=", "_fma.b._0.po=230031").Replace("_fma.b._0.de=", "_fma.b._0.de=" + Server.UrlEncode("啊峰")).Replace("_fma.b._0.u=", "_fma.b._0.u=0").Replace("_fma.b._0.di=1", "_fma.b._0.di=370522").Replace("_fma.b._0.deli=", "_fma.b._0.deli=13888888888");
            postStr += "&_fma.b._0.s=2";
            //postStr = Server.UrlEncode(postStr);

            return postStr;
        }


        protected override void OnClosed(EventArgs e)
        {
            AppConfigInfo config = new AppConfigInfo();
            config.UserName = tbx_UserName.Text;
            config.PassWord = SecurityUtils.DesEncode(tbx_PassWord.Text);
            config.GoodsUrl = tbx_goodsUrl.Text;
            ConfigAccess<AppConfigInfo>.SaveConfig(config);

            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InputCheckCodeForm().Show();
        }
    }
}
