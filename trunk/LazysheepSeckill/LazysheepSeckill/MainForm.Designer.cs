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
            this.tbx_PassWord = new System.Windows.Forms.TextBox();
            this.btn_LoginTaobao = new System.Windows.Forms.Button();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.gbx_goodsinfo = new System.Windows.Forms.GroupBox();
            this.btn_openGoods = new System.Windows.Forms.Button();
            this.tbx_goodsUrl = new System.Windows.Forms.TextBox();
            this.lbl_goodsUrl = new System.Windows.Forms.Label();
            this.tabControlMain = new Crownwood.Magic.Controls.TabControl();
            this.wbr_main = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbx_taobaoLogin.SuspendLayout();
            this.gbx_goodsinfo.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_taobaoLogin
            // 
            this.gbx_taobaoLogin.Controls.Add(this.tbx_PassWord);
            this.gbx_taobaoLogin.Controls.Add(this.btn_LoginTaobao);
            this.gbx_taobaoLogin.Controls.Add(this.lbl_PassWord);
            this.gbx_taobaoLogin.Controls.Add(this.tbx_UserName);
            this.gbx_taobaoLogin.Controls.Add(this.lbl_UserName);
            resources.ApplyResources(this.gbx_taobaoLogin, "gbx_taobaoLogin");
            this.gbx_taobaoLogin.Name = "gbx_taobaoLogin";
            this.gbx_taobaoLogin.TabStop = false;
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
            // tbx_UserName
            // 
            resources.ApplyResources(this.tbx_UserName, "tbx_UserName");
            this.tbx_UserName.Name = "tbx_UserName";
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbx_goodsinfo);
            this.Controls.Add(this.gbx_taobaoLogin);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.gbx_taobaoLogin.ResumeLayout(false);
            this.gbx_taobaoLogin.PerformLayout();
            this.gbx_goodsinfo.ResumeLayout(false);
            this.gbx_goodsinfo.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_taobaoLogin;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tbx_UserName;
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
    }
}

