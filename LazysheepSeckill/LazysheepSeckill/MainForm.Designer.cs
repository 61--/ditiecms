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
            this.lbl_GoodsStock = new System.Windows.Forms.Label();
            this.lbl_GoodsPrice = new System.Windows.Forms.Label();
            this.lbl_GoodsStatus = new System.Windows.Forms.Label();
            this.lbl_GoodsTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openGoods = new System.Windows.Forms.Button();
            this.tbx_goodsUrl = new System.Windows.Forms.TextBox();
            this.lbl_goodsUrl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.stl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.skin = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.SeckillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BeginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserCenterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.F1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTabPage = new System.Windows.Forms.TabPage();
            this.startPageBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx_taobaoLogin.SuspendLayout();
            this.gbx_goodsinfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.startTabPage.SuspendLayout();
            this.tabControlMain.SuspendLayout();
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
            this.gbx_goodsinfo.Controls.Add(this.lbl_GoodsStock);
            this.gbx_goodsinfo.Controls.Add(this.lbl_GoodsPrice);
            this.gbx_goodsinfo.Controls.Add(this.lbl_GoodsStatus);
            this.gbx_goodsinfo.Controls.Add(this.lbl_GoodsTitle);
            this.gbx_goodsinfo.Controls.Add(this.label4);
            this.gbx_goodsinfo.Controls.Add(this.label3);
            this.gbx_goodsinfo.Controls.Add(this.label2);
            this.gbx_goodsinfo.Controls.Add(this.label1);
            this.gbx_goodsinfo.Controls.Add(this.btn_openGoods);
            this.gbx_goodsinfo.Controls.Add(this.tbx_goodsUrl);
            this.gbx_goodsinfo.Controls.Add(this.lbl_goodsUrl);
            resources.ApplyResources(this.gbx_goodsinfo, "gbx_goodsinfo");
            this.gbx_goodsinfo.Name = "gbx_goodsinfo";
            this.gbx_goodsinfo.TabStop = false;
            // 
            // lbl_GoodsStock
            // 
            resources.ApplyResources(this.lbl_GoodsStock, "lbl_GoodsStock");
            this.lbl_GoodsStock.Name = "lbl_GoodsStock";
            // 
            // lbl_GoodsPrice
            // 
            resources.ApplyResources(this.lbl_GoodsPrice, "lbl_GoodsPrice");
            this.lbl_GoodsPrice.Name = "lbl_GoodsPrice";
            // 
            // lbl_GoodsStatus
            // 
            resources.ApplyResources(this.lbl_GoodsStatus, "lbl_GoodsStatus");
            this.lbl_GoodsStatus.Name = "lbl_GoodsStatus";
            // 
            // lbl_GoodsTitle
            // 
            resources.ApplyResources(this.lbl_GoodsTitle, "lbl_GoodsTitle");
            this.lbl_GoodsTitle.Name = "lbl_GoodsTitle";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslabelMessage,
            this.stl_Status});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // sslabelMessage
            // 
            this.sslabelMessage.Name = "sslabelMessage";
            resources.ApplyResources(this.sslabelMessage, "sslabelMessage");
            // 
            // stl_Status
            // 
            this.stl_Status.Name = "stl_Status";
            resources.ApplyResources(this.stl_Status, "stl_Status");
            // 
            // skin
            // 
            this.skin.MenuFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.skin.ResSysMenuClose = "关闭(&C)    Alt+F4";
            this.skin.SerialNumber = "";
            this.skin.SkinFile = "";
            this.skin.TitleFont = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.BackgroundImage = global::LazysheepSeckill.Properties.Resources.menubarbg;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeckillMenuItem,
            this.UserMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // SeckillMenuItem
            // 
            this.SeckillMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BeginMenuItem,
            this.PauseMenuItem,
            this.StopMenuItem,
            this.toolStripSeparator4,
            this.ExitMenuItem});
            this.SeckillMenuItem.Image = global::LazysheepSeckill.Properties.Resources.television;
            this.SeckillMenuItem.Name = "SeckillMenuItem";
            resources.ApplyResources(this.SeckillMenuItem, "SeckillMenuItem");
            // 
            // BeginMenuItem
            // 
            this.BeginMenuItem.Image = global::LazysheepSeckill.Properties.Resources.start;
            resources.ApplyResources(this.BeginMenuItem, "BeginMenuItem");
            this.BeginMenuItem.Name = "BeginMenuItem";
            this.BeginMenuItem.Click += new System.EventHandler(this.SeckillMenuItem_Click);
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Image = global::LazysheepSeckill.Properties.Resources.pause;
            resources.ApplyResources(this.PauseMenuItem, "PauseMenuItem");
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Click += new System.EventHandler(this.SeckillMenuItem_Click);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Image = global::LazysheepSeckill.Properties.Resources.stop;
            resources.ApplyResources(this.StopMenuItem, "StopMenuItem");
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Click += new System.EventHandler(this.SeckillMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.SeckillMenuItem_Click);
            // 
            // UserMenuItem
            // 
            this.UserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserCenterMenuItem,
            this.toolStripSeparator3,
            this.AddressMenuItem,
            this.AccountMenuItem});
            this.UserMenuItem.Image = global::LazysheepSeckill.Properties.Resources.user_green;
            this.UserMenuItem.Name = "UserMenuItem";
            resources.ApplyResources(this.UserMenuItem, "UserMenuItem");
            // 
            // UserCenterMenuItem
            // 
            resources.ApplyResources(this.UserCenterMenuItem, "UserCenterMenuItem");
            this.UserCenterMenuItem.Name = "UserCenterMenuItem";
            this.UserCenterMenuItem.Click += new System.EventHandler(this.UserMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // AddressMenuItem
            // 
            this.AddressMenuItem.Name = "AddressMenuItem";
            resources.ApplyResources(this.AddressMenuItem, "AddressMenuItem");
            this.AddressMenuItem.Click += new System.EventHandler(this.UserMenuItem_Click);
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.Image = global::LazysheepSeckill.Properties.Resources.credit_card;
            this.AccountMenuItem.Name = "AccountMenuItem";
            resources.ApplyResources(this.AccountMenuItem, "AccountMenuItem");
            this.AccountMenuItem.Click += new System.EventHandler(this.UserMenuItem_Click);
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimingMenuItem,
            this.CompareTimeMenuItem,
            this.CalculatorMenuItem,
            this.toolStripSeparator2,
            this.OptionMenuItem});
            this.ToolsMenuItem.Image = global::LazysheepSeckill.Properties.Resources.wrench_screwdriver;
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            resources.ApplyResources(this.ToolsMenuItem, "ToolsMenuItem");
            // 
            // TimingMenuItem
            // 
            this.TimingMenuItem.Image = global::LazysheepSeckill.Properties.Resources.hourglass;
            this.TimingMenuItem.Name = "TimingMenuItem";
            resources.ApplyResources(this.TimingMenuItem, "TimingMenuItem");
            this.TimingMenuItem.Click += new System.EventHandler(this.ToolsMenuItem_Click);
            // 
            // CompareTimeMenuItem
            // 
            this.CompareTimeMenuItem.Image = global::LazysheepSeckill.Properties.Resources.alarm_clock_select;
            this.CompareTimeMenuItem.Name = "CompareTimeMenuItem";
            resources.ApplyResources(this.CompareTimeMenuItem, "CompareTimeMenuItem");
            this.CompareTimeMenuItem.Click += new System.EventHandler(this.ToolsMenuItem_Click);
            // 
            // CalculatorMenuItem
            // 
            this.CalculatorMenuItem.Name = "CalculatorMenuItem";
            resources.ApplyResources(this.CalculatorMenuItem, "CalculatorMenuItem");
            this.CalculatorMenuItem.Click += new System.EventHandler(this.ToolsMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // OptionMenuItem
            // 
            this.OptionMenuItem.Image = global::LazysheepSeckill.Properties.Resources.option;
            this.OptionMenuItem.Name = "OptionMenuItem";
            resources.ApplyResources(this.OptionMenuItem, "OptionMenuItem");
            this.OptionMenuItem.Click += new System.EventHandler(this.ToolsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.F1MenuItem,
            this.UpdateMenuItem,
            this.toolStripSeparator1,
            this.HomeMenuItem,
            this.AboutMenuItem});
            this.HelpMenuItem.Image = global::LazysheepSeckill.Properties.Resources.question;
            this.HelpMenuItem.Name = "HelpMenuItem";
            resources.ApplyResources(this.HelpMenuItem, "HelpMenuItem");
            // 
            // F1MenuItem
            // 
            this.F1MenuItem.Name = "F1MenuItem";
            resources.ApplyResources(this.F1MenuItem, "F1MenuItem");
            this.F1MenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            resources.ApplyResources(this.UpdateMenuItem, "UpdateMenuItem");
            this.UpdateMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // HomeMenuItem
            // 
            this.HomeMenuItem.Image = global::LazysheepSeckill.Properties.Resources.home;
            this.HomeMenuItem.Name = "HomeMenuItem";
            resources.ApplyResources(this.HomeMenuItem, "HomeMenuItem");
            this.HomeMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Image = global::LazysheepSeckill.Properties.Resources.information;
            resources.ApplyResources(this.AboutMenuItem, "AboutMenuItem");
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // startTabPage
            // 
            this.startTabPage.Controls.Add(this.startPageBrowser);
            resources.ApplyResources(this.startTabPage, "startTabPage");
            this.startTabPage.Name = "startTabPage";
            this.startTabPage.UseVisualStyleBackColor = true;
            // 
            // startPageBrowser
            // 
            resources.ApplyResources(this.startPageBrowser, "startPageBrowser");
            this.startPageBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.startPageBrowser.Name = "startPageBrowser";
            this.startPageBrowser.Url = new System.Uri("http://www.baidu.com", System.UriKind.Absolute);
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.startTabPage);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.gbx_goodsinfo);
            this.Controls.Add(this.gbx_taobaoLogin);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbx_taobaoLogin.ResumeLayout(false);
            this.gbx_taobaoLogin.PerformLayout();
            this.gbx_goodsinfo.ResumeLayout(false);
            this.gbx_goodsinfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.startTabPage.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslabelMessage;
        private Sunisoft.IrisSkin.SkinEngine skin;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem SeckillMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem F1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem HomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompareTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculatorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserCenterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BeginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimingMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OptionMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ComboBox cbx_UserName;
        private System.Windows.Forms.ToolStripMenuItem PauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.TabPage startTabPage;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.WebBrowser startPageBrowser;
        private System.Windows.Forms.ToolStripStatusLabel stl_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_GoodsTitle;
        private System.Windows.Forms.Label lbl_GoodsStatus;
        private System.Windows.Forms.Label lbl_GoodsPrice;
        private System.Windows.Forms.Label lbl_GoodsStock;
    }
}

