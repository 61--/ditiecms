using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Config;
using HtmlAgilityPack;
using Utils;
using Core;

namespace LazysheepSeckill
{
    public partial class MainForm : Form
    {
        string strServer = string.Empty;
        string strPath = string.Empty;
        private WebBrowser mUserBrowser;
        private TabPage userTabPage;
        private SplashScreen mSplashScreen;
        private UserConfigInfo mUserConfig;

        public MainForm(SplashScreen splash)
        {
            mSplashScreen = splash;
            mSplashScreen.SetProgress("正在加载系统组件...", 0.2);
            InitializeComponent();
            mSplashScreen.SetProgress("正在读取程序配置...", 0.6);
            InitializeData();
            mSplashScreen.SetProgress("程序加载完毕...", 1.0);
            mSplashScreen.Hide();
        }

        #region 业务逻辑方法
        private string GetPwdByUserName(string userName)
        {
            foreach (Account ac in mUserConfig.Account)
            {
                if (ac.UserName == userName)
                {
                    return SecurityUtils.DesDecode(ac.PassWord);
                }
            }
            return null;
        }

        private void AddorEditAccount(string userName, string passWord)
        {
            foreach (Account ac in mUserConfig.Account)
            {
                if (ac.UserName == userName)
                {
                    ac.PassWord = SecurityUtils.DesEncode(passWord);
                    return;
                }
            }
            Account account = new Account();
            account.UserName = userName;
            account.PassWord = SecurityUtils.DesEncode(passWord);
            mUserConfig.Account.Add(account);
        }

        private void DebugTest(string s, string tag)
        {
            System.IO.FileStream fs = new System.IO.FileStream(string.Format("{0}\\log_{1}-{2}.html",
                System.Environment.CurrentDirectory, DateTime.Now.ToString("yyyyMMddHHmmss"), tag), System.IO.FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(s);
            fs.Write(data, 0, data.Length);
            fs.Close();

        }

        [System.Runtime.InteropServices.DllImport("wininet.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);

        private void WriteCookies()
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (System.Net.Cookie cook in http.Cookies)
            //{
            //    sb.AppendFormat("{0} = {1}\r\n", cook.Name, cook.Value);
            //}
            //DebugTest(sb.ToString(), "cookie");
        }
        #endregion 业务逻辑方法

        #region 公共控件事件
        private void cbx_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_PassWord.Text = GetPwdByUserName(cbx_UserName.SelectedValue.ToString());
        }

        private void btn_LoginTaobao_Click(object sender, EventArgs e)
        {
            AddorEditAccount(cbx_UserName.Text, tbx_PassWord.Text);

            bool result = CoreFactory.GetInstance().Login(cbx_UserName.Text, tbx_PassWord.Text);
            if (result)
            {
                MessageBox.Show(this, "登录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, CoreFactory.GetInstance().ErrorMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_openGoods_Click(object sender, EventArgs e)
        {
            string goodsUrl = tbx_goodsUrl.Text.Trim();
            if (string.IsNullOrEmpty(goodsUrl))
            {
                MessageBox.Show(this, "请输入商品地址！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tabControlMain.Controls.Count == 1)
            {
                mUserBrowser = new WebBrowser();
                mUserBrowser.Anchor = (System.Windows.Forms.AnchorStyles)15;
                mUserBrowser.Size = new System.Drawing.Size(678, 346);
                mUserBrowser.Location = new System.Drawing.Point(-3, -3);
                mUserBrowser.ScrollBarsEnabled = true;
                mUserBrowser.ScriptErrorsSuppressed = true;
                mUserBrowser.Url = new Uri("about:blank");
                userTabPage = new TabPage();
                userTabPage.Size = new System.Drawing.Size(672, 340);
                userTabPage.Controls.Add(mUserBrowser);
                userTabPage.Text = "空白页";
                this.tabControlMain.TabPages.Add(userTabPage);
                this.tabControlMain.SelectedIndex = 1;
            }
            else
            {
                this.tabControlMain.SelectedIndex = 1;
            }

            Uri goodsUri = new Uri(goodsUrl);
            if (CoreFactory.GetInstance().Cookies != null)
            {
                System.Net.CookieContainer ccr = new System.Net.CookieContainer();
                ccr.Add(goodsUri, CoreFactory.GetInstance().Cookies);
                System.Net.CookieCollection ccn = ccr.GetCookies(goodsUri);
                foreach (System.Net.Cookie c in ccn)
                {
                    InternetSetCookie(goodsUrl, c.Name, c.Value);
                }
            }
            mUserBrowser.Url = goodsUri;
            mUserBrowser.Navigated += new WebBrowserNavigatedEventHandler(UserBrowser_Navigate);
            mUserBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(UserBrowser_NewWindow);
            mUserBrowser.StatusTextChanged += new EventHandler(UserBrowser_StatusTextChanged);
            mUserBrowser.Dock = DockStyle.Fill;
            //mUserBrowser.Document.Cookie;

            //string html = string.Empty;
            //http.Method = "GET";
            //html = http.RequestUrl(goodsUrl);
            //WriteCookies();
            //if (http.Error)
            //{
            //    MessageBox.Show(http.ErrorMsg);
            //}
            //else
            //{
            //    this.mUserBrowser.DocumentText = html;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InputCheckCodeForm checkCodeForm = new InputCheckCodeForm();
            ////InputCheckCodeForm.LoginTaobaoEvent += new InputCheckCodeForm.LoginTaobaoDelegate(LoginTaobao);
            //checkCodeForm.Owner = this;
            //checkCodeForm.Show(this);
        }
        #endregion 公共控件事件

        #region 浏览器事件
        private void UserBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            stl_Status.Text = mUserBrowser.StatusText;
        }

        private void UserBrowser_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string newUrl = mUserBrowser.StatusText;
            mUserBrowser.Navigate(newUrl);
            e.Cancel = true;
        }

        private void UserBrowser_Navigate(object sender, EventArgs e)
        {
            tbx_goodsUrl.Text = mUserBrowser.Url.ToString();
            userTabPage.Text = mUserBrowser.DocumentTitle;
        }
        #endregion 浏览器事件

        #region 主窗体事件
        private void InitializeData()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            mUserConfig = ConfigAccess<UserConfigInfo>.GetConfig();
            if (mUserConfig == null)
            {
                return;
            }
            if (mUserConfig.Account != null && mUserConfig.Account.Count > 0)
            {
                cbx_UserName.DataSource = mUserConfig.Account;
                cbx_UserName.DisplayMember = "UserName";
                cbx_UserName.ValueMember = "UserName";
                if (!string.IsNullOrEmpty(mUserConfig.DefaultAccount))
                {
                    cbx_UserName.SelectedValue = mUserConfig.DefaultAccount;
                }
                else
                {
                    cbx_UserName.SelectedIndex = 0;
                }
                tbx_PassWord.Text = GetPwdByUserName(cbx_UserName.SelectedValue.ToString());
                tbx_goodsUrl.Text = mUserConfig.GoodsUrl;
            }

            AppConfigInfo mAppConfig = ConfigAccess<AppConfigInfo>.GetConfig();
            if (mAppConfig != null)
            {
                this.TopMost = mAppConfig.WindowTopMost;
                this.skin.SkinFile = mAppConfig.SkinFile;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mSplashScreen.Hide();
            this.Activate();
        }

        protected override void OnClosed(EventArgs e)
        {
            mUserConfig = mUserConfig ?? new UserConfigInfo();
            if (cbx_UserName.SelectedValue != null)
            {
                mUserConfig.DefaultAccount = cbx_UserName.SelectedValue.ToString();
            }
            mUserConfig.GoodsUrl = tbx_goodsUrl.Text;

            try
            {
                ConfigAccess<UserConfigInfo>.SaveConfig(mUserConfig);
            }
            catch (Exception ex)
            {

            }
            base.OnClosed(e);
        }
        #endregion 主窗体事件

        #region 菜单栏点击事件
        private void SeckillMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu_click = (ToolStripMenuItem)sender;
            switch (menu_click.Name)
            {
                case "BeginMenuItem":
                    break;
                case "PauseMenuItem":
                    break;
                case "StopMenuItem":
                    break;
                case "ExitMenuItem":
                    if (MessageBox.Show(this, "是否要退出应用程序？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void UserMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu_click = (ToolStripMenuItem)sender;
            switch (menu_click.Name)
            {
                case "F1MenuItem":
                    break;
                case "UpdateMenuItem":
                    break;
                case "HomeMenuItem":
                    break;
                case "AboutMenuItem":
                    AboutForm aboutForm = new AboutForm();
                    aboutForm.ShowDialog(this);
                    break;
            }
        }
        #endregion 菜单栏点击事件
    }
}
