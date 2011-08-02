namespace Core
{
    partial class CheckCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCodeForm));
            this.lbl_Info = new System.Windows.Forms.Label();
            this.cbx_AutoSubmit = new System.Windows.Forms.CheckBox();
            this.tbx_CheckCode = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_ErrInfo = new System.Windows.Forms.Label();
            this.pic_CheckCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheckCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(13, 13);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(155, 12);
            this.lbl_Info.TabIndex = 2;
            this.lbl_Info.Text = "请输入以下图片中的验证码:";
            // 
            // cbx_AutoSubmit
            // 
            this.cbx_AutoSubmit.AutoSize = true;
            this.cbx_AutoSubmit.Checked = true;
            this.cbx_AutoSubmit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_AutoSubmit.Location = new System.Drawing.Point(15, 97);
            this.cbx_AutoSubmit.Name = "cbx_AutoSubmit";
            this.cbx_AutoSubmit.Size = new System.Drawing.Size(144, 16);
            this.cbx_AutoSubmit.TabIndex = 3;
            this.cbx_AutoSubmit.Text = "输入验证码后自动回车";
            this.cbx_AutoSubmit.UseVisualStyleBackColor = true;
            // 
            // tbx_CheckCode
            // 
            this.tbx_CheckCode.Location = new System.Drawing.Point(176, 34);
            this.tbx_CheckCode.MaxLength = 4;
            this.tbx_CheckCode.Name = "tbx_CheckCode";
            this.tbx_CheckCode.Size = new System.Drawing.Size(96, 21);
            this.tbx_CheckCode.TabIndex = 0;
            this.tbx_CheckCode.TextChanged += new System.EventHandler(this.tbx_CheckCode_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(175, 61);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(98, 23);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "确 定(&Enter)";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_ErrInfo
            // 
            this.lbl_ErrInfo.AutoSize = true;
            this.lbl_ErrInfo.ForeColor = System.Drawing.Color.Green;
            this.lbl_ErrInfo.Location = new System.Drawing.Point(165, 98);
            this.lbl_ErrInfo.Name = "lbl_ErrInfo";
            this.lbl_ErrInfo.Size = new System.Drawing.Size(113, 12);
            this.lbl_ErrInfo.TabIndex = 4;
            this.lbl_ErrInfo.Text = "点击图片更换验证码";
            // 
            // pic_CheckCode
            // 
            this.pic_CheckCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CheckCode.Location = new System.Drawing.Point(15, 33);
            this.pic_CheckCode.Name = "pic_CheckCode";
            this.pic_CheckCode.Size = new System.Drawing.Size(150, 50);
            this.pic_CheckCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_CheckCode.TabIndex = 1;
            this.pic_CheckCode.TabStop = false;
            this.pic_CheckCode.Click += new System.EventHandler(this.pic_CheckCode_Click);
            // 
            // CheckCodeForm
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 118);
            this.Controls.Add(this.lbl_ErrInfo);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_CheckCode);
            this.Controls.Add(this.cbx_AutoSubmit);
            this.Controls.Add(this.pic_CheckCode);
            this.Controls.Add(this.lbl_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 150);
            this.Name = "CheckCodeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入验证码";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheckCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.PictureBox pic_CheckCode;
        private System.Windows.Forms.CheckBox cbx_AutoSubmit;
        private System.Windows.Forms.TextBox tbx_CheckCode;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_ErrInfo;
    }
}