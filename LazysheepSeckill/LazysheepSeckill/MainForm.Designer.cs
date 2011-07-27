namespace LazysheepSeckill
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbx_taobaoLogin = new System.Windows.Forms.GroupBox();
            this.cbx_UserName = new System.Windows.Forms.ComboBox();
            this.tbx_PassWord = new System.Windows.Forms.TextBox();
            this.btn_LoginTaobao = new System.Windows.Forms.Button();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.gbx_goodsinfo = new System.Windows.Forms.GroupBox();
            this.btn_openGoods = new System.Windows.Forms.Button();
            this.tbx_goodsUrl = new System.Windows.Forms.TextBox();
            this.lbl_goodsUrl = new System.Windows.Forms.Label();
            this.tabControlMain = new Crownwood.Magic.Controls.TabControl();
            this.wbr_main = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.skin = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.地址库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帐号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.时间校对TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助F1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_taobaoLogin.SuspendLayout();
            this.gbx_goodsinfo.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_taobaoLogin
            // 
            this.gbx_taobaoLogin.Controls.Add(this.cbx_UserName);
            this.gbx_taobaoLogin.Controls.Add(this.tbx_PassWord);
            this.gbx_taobaoLogin.Controls.Add(this.btn_LoginTaobao);
            this.gbx_taobaoLogin.Controls.Add(this.lbl_PassWord);
            this.gbx_taobaoLogin.Controls.Add(this.lbl_UserName);
            resources.ApplyResources(this.gbx_taobaoLogin, "gbx_taobaoLogin");
            this.gbx_taobaoLogin.Name = "gbx_taobaoLogin";
            this.gbx_taobaoLogin.TabStop = false;
            // 
            // cbx_UserName
            // 
            this.cbx_UserName.FormattingEnabled = true;
            resources.ApplyResources(this.cbx_UserName, "cbx_UserName");
            this.cbx_UserName.Name = "cbx_UserName";
            this.cbx_UserName.SelectedIndexChanged += new System.EventHandler(this.cbx_UserName_SelectedIndexChanged);
            // 
            // tbx_PassWord
            // 
            resources.ApplyResources(this.tbx_PassWord, "tbx_PassWord");
            this.tbx_PassWord.Name = "tbx_PassWord";
            this.tbx_PassWord.UseSystemPasswordChar = true;
            // 
            // btn_LoginTaobao
            // 
            resources.ApplyResources(this.btn_LoginTaobao, "btn_LoginTaobao");
            this.btn_LoginTaobao.Name = "btn_LoginTaobao";
            this.btn_LoginTaobao.UseVisualStyleBackColor = true;
            this.btn_LoginTaobao.Click += new System.EventHandler(this.btn_LoginTaobao_Click);
            // 
            // lbl_PassWord
            // 
            resources.ApplyResources(this.lbl_PassWord, "lbl_PassWord");
            this.lbl_PassWord.Name = "lbl_PassWord";
            // 
            // lbl_UserName
            // 
            resources.ApplyResources(this.lbl_UserName, "lbl_UserName");
            this.lbl_UserName.Name = "lbl_UserName";
            // 
            // gbx_goodsinfo
            // 
            this.gbx_goodsinfo.Controls.Add(this.btn_openGoods);
            this.gbx_goodsinfo.Controls.Add(this.tbx_goodsUrl);
            this.gbx_goodsinfo.Controls.Add(this.lbl_goodsUrl);
            resources.ApplyResources(this.gbx_goodsinfo, "gbx_goodsinfo");
            this.gbx_goodsinfo.Name = "gbx_goodsinfo";
            this.gbx_goodsinfo.TabStop = false;
            // 
            // btn_openGoods
            // 
            resources.ApplyResources(this.btn_openGoods, "btn_openGoods");
            this.btn_openGoods.Name = "btn_openGoods";
            this.btn_openGoods.UseVisualStyleBackColor = true;
            this.btn_openGoods.Click += new System.EventHandler(this.btn_openGoods_Click);
            // 
            // tbx_goodsUrl
            // 
            resources.ApplyResources(this.tbx_goodsUrl, "tbx_goodsUrl");
            this.tbx_goodsUrl.Name = "tbx_goodsUrl";
            // 
            // lbl_goodsUrl
            // 
            resources.ApplyResources(this.lbl_goodsUrl, "lbl_goodsUrl");
            this.lbl_goodsUrl.Name = "lbl_goodsUrl";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.wbr_main);
            this.tabControlMain.HideTabsMode = Crownwood.Magic.Controls.TabControl.HideTabsModes.ShowAlways;
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.PositionTop = true;
            this.tabControlMain.ShowArrows = true;
            this.tabControlMain.ShowClose = true;
            // 
            // wbr_main
            // 
            resources.ApplyResources(this.wbr_main, "wbr_main");
            this.wbr_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbr_main.Name = "wbr_main";
            this.wbr_main.ScrollBarsEnabled = false;
            this.wbr_main.Url = new System.Uri("http://www.tuanlet.com", System.UriKind.Absolute);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelMessage});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // sslabelMessage
            // 
            this.sslabelMessage.Name = "sslabelMessage";
            resources.ApplyResources(this.sslabelMessage, "sslabelMessage");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skin
            // 
            this.skin.SerialNumber = "";
            this.skin.SkinFile = "";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.BackgroundImage = global::LazysheepSeckill.Properties.Resources.menubarbg;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.UserMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.退出EToolStripMenuItem});
            this.FileMenuItem.Image = global::LazysheepSeckill.Properties.Resources.television;
            this.FileMenuItem.Name = "FileMenuItem";
            resources.ApplyResources(this.FileMenuItem, "FileMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            resources.ApplyResources(this.退出EToolStripMenuItem, "退出EToolStripMenuItem");
            // 
            // UserMenuItem
            // 
            this.UserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户中心ToolStripMenuItem,
            this.toolStripSeparator3,
            this.地址库ToolStripMenuItem,
            this.帐号管理ToolStripMenuItem});
            this.UserMenuItem.Image = global::LazysheepSeckill.Properties.Resources.user_green;
            this.UserMenuItem.Name = "UserMenuItem";
            resources.ApplyResources(this.UserMenuItem, "UserMenuItem");
            // 
            // 用户中心ToolStripMenuItem
            // 
            this.用户中心ToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.user_center;
            resources.ApplyResources(this.用户中心ToolStripMenuItem, "用户中心ToolStripMenuItem");
            this.用户中心ToolStripMenuItem.Name = "用户中心ToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // 地址库ToolStripMenuItem
            // 
            this.地址库ToolStripMenuItem.Name = "地址库ToolStripMenuItem";
            resources.ApplyResources(this.地址库ToolStripMenuItem, "地址库ToolStripMenuItem");
            // 
            // 帐号管理ToolStripMenuItem
            // 
            this.帐号管理ToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.credit_card;
            this.帐号管理ToolStripMenuItem.Name = "帐号管理ToolStripMenuItem";
            resources.ApplyResources(this.帐号管理ToolStripMenuItem, "帐号管理ToolStripMenuItem");
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.时间校对TToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.选项OToolStripMenuItem});
            this.ToolsMenuItem.Image = global::LazysheepSeckill.Properties.Resources.compass;
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            resources.ApplyResources(this.ToolsMenuItem, "ToolsMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::LazysheepSeckill.Properties.Resources.hourglass;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // 时间校对TToolStripMenuItem
            // 
            this.时间校对TToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.alarm_clock_select;
            this.时间校对TToolStripMenuItem.Name = "时间校对TToolStripMenuItem";
            resources.ApplyResources(this.时间校对TToolStripMenuItem, "时间校对TToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.wrench_screwdriver;
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            resources.ApplyResources(this.选项OToolStripMenuItem, "选项OToolStripMenuItem");
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助F1ToolStripMenuItem,
            this.检查更新ToolStripMenuItem,
            this.toolStripSeparator1,
            this.关于ToolStripMenuItem,
            this.关于本软件ToolStripMenuItem});
            this.HelpMenuItem.Image = global::LazysheepSeckill.Properties.Resources.question;
            this.HelpMenuItem.Name = "HelpMenuItem";
            resources.ApplyResources(this.HelpMenuItem, "HelpMenuItem");
            // 
            // 帮助F1ToolStripMenuItem
            // 
            this.帮助F1ToolStripMenuItem.Name = "帮助F1ToolStripMenuItem";
            resources.ApplyResources(this.帮助F1ToolStripMenuItem, "帮助F1ToolStripMenuItem");
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            resources.ApplyResources(this.检查更新ToolStripMenuItem, "检查更新ToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.home;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            // 
            // 关于本软件ToolStripMenuItem
            // 
            this.关于本软件ToolStripMenuItem.Image = global::LazysheepSeckill.Properties.Resources.information;
            this.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem";
            resources.ApplyResources(this.关于本软件ToolStripMenuItem, "关于本软件ToolStripMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.gbx_goodsinfo);
            this.Controls.Add(this.gbx_taobaoLogin);
            this.Controls.Add(this.tabControlMain);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbx_taobaoLogin.ResumeLayout(false);
            this.gbx_taobaoLogin.PerformLayout();
            this.gbx_goodsinfo.ResumeLayout(false);
            this.gbx_goodsinfo.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_taobaoLogin;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_PassWord;
        private System.Windows.Forms.TextBox tbx_PassWord;
        private System.Windows.Forms.Button btn_LoginTaobao;
        private System.Windows.Forms.GroupBox gbx_goodsinfo;
        private System.Windows.Forms.Label lbl_goodsUrl;
        private System.Windows.Forms.TextBox tbx_goodsUrl;
        private System.Windows.Forms.Button btn_openGoods;
        public Crownwood.Magic.Controls.TabControl tabControlMain;
        private System.Windows.Forms.WebBrowser wbr_main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelMessage;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skin;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助F1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间校对TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地址库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帐号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ComboBox cbx_UserName;
    }
}

