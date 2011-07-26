using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Config;
using HtmlAgilityPack;
using Utils;

namespace LazysheepSeckill
{
    public partial class MainForm : Form
    {
        string strServer = string.Empty;
        string strPath = string.Empty;
        HttpUtils http = new HttpUtils();
        public static string PASSVALUE;
        private SplashScreen mSplashScreen;
        private AppConfigInfo mConfig;

        public MainForm(SplashScreen splash)
        {
            mSplashScreen = splash;
            mSplashScreen.SetProgress("正在加载系统组件...", 0.2);
            InitializeComponent();
            mSplashScreen.SetProgress("正在加载程序数据...", 0.6);
            InitializeData();
            mSplashScreen.SetProgress("程序加载完毕...", 1.0);
        }

        private void InitializeData()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            mConfig = ConfigAccess<AppConfigInfo>.GetConfig();
            if (mConfig == null)
            {
                return;
            }
            if (mConfig.UserData != null)
            {
                tbx_UserName.Text = mConfig.UserData.UserName;
                tbx_PassWord.Text = SecurityUtils.DesDecode(mConfig.UserData.PassWord);
                tbx_goodsUrl.Text = mConfig.UserData.GoodsUrl;
            }
            if (mConfig.SystemSetting != null)
            {
                this.TopMost = mConfig.SystemSetting.WindowTopMost;
                this.skin.SkinFile = mConfig.SystemSetting.SkinFile;
            }
        }

        private void DebugTest(string s, string tag)
        {
            System.IO.FileStream fs = new System.IO.FileStream(string.Format("{0}\\log_{1}-{2}.html",
                System.Environment.CurrentDirectory, DateTime.Now.ToString("yyyyMMddHHmmss"), tag), System.IO.FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(s);
            fs.Write(data, 0, data.Length);
            fs.Close();

        }

        private void LoginTaobao(object checkCode)
        {
            string html = string.Empty;
            string loginUrl = "https://login.taobao.com/member/login.jhtml";
            http.Method = "GET";

            html = http.RequestUrl("http://login.taobao.com/");
            html = html.Substring(0, html.IndexOf("</form>")).Substring(html.IndexOf("<form id=\"J_StaticForm\""));

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            HtmlNodeCollection inputNodes = doc.DocumentNode.SelectNodes("//input[@type='hidden']");
            if (inputNodes == null)
            {
                MessageBox.Show("未知错误，请检查网络是否正常后重试。");
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

            string need_check_code = doc.DocumentNode.SelectSingleNode("//input[@name='need_check_code']").Attributes["value"].Value;
            if (need_check_code == "true")
            {
                PASSVALUE = doc.GetElementbyId("J_StandardCode_m").Attributes["data-src"].Value;

                InputCheckCodeForm ccForm = new InputCheckCodeForm();
                if (ccForm.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                http.AddPostKey("TPL_checkcode", checkCode == null ? "" : checkCode.ToString());
                http.EditPostKey("need_check_code", "true");
            }
            else
            {
                http.AddPostKey("TPL_checkcode", string.Empty);
                http.EditPostKey("need_check_code", string.Empty);
            }
            
            http.Method = "POST";

            html = http.RequestUrl(loginUrl);

            if (http.Error)
            {
                MessageBox.Show(http.ErrorMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (html.IndexOf("window.location = \"http") > 0)
                {
                    string url = html.Substring(html.IndexOf("window.location = \"http") + 19, 255).Substring(0, html.IndexOf("\"") - 7);
                    http.Method = "GET";
                    //http.RequestUrl(url);
                    tbx_goodsUrl.Text = url;
                    MessageBox.Show(this, "登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (html.IndexOf("请输入验证码") > 0)
                {
                    MessageBox.Show(this, "请输入验证码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (html.IndexOf("密码和账户名不匹配") > 0 || html.IndexOf("该账户名不存在") > 0)
                {
                    MessageBox.Show(this, "登录用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(this, "未知错误，请重新登录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_LoginTaobao_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ParameterizedThreadStart(LoginTaobao));
            t.IsBackground = true;
            t.Start(null);
        }

        private void btn_openGoods_Click(object sender, EventArgs e)
        {
            string goodsUrl = tbx_goodsUrl.Text.Trim();
            if (string.IsNullOrEmpty(goodsUrl))
            {
                MessageBox.Show(this, "请输入商品地址！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string html = string.Empty;
            http.Method = "GET";
            html = http.RequestUrl(goodsUrl);
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
            mConfig = mConfig ?? new AppConfigInfo();
            mConfig.UserData = new UserData();
            mConfig.UserData.UserName = tbx_UserName.Text;
            mConfig.UserData.PassWord = SecurityUtils.DesEncode(tbx_PassWord.Text);
            mConfig.UserData.GoodsUrl = tbx_goodsUrl.Text;
            ConfigAccess<AppConfigInfo>.SaveConfig(mConfig);

            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputCheckCodeForm checkCodeForm = new InputCheckCodeForm();
            //InputCheckCodeForm.LoginTaobaoEvent += new InputCheckCodeForm.LoginTaobaoDelegate(LoginTaobao);
            checkCodeForm.Owner = this;
            checkCodeForm.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mSplashScreen.Hide();
            this.Activate();
        }
    }
}
