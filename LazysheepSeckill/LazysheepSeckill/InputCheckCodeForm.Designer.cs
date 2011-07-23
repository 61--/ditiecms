namespace LazysheepSeckill
{
    partial class InputCheckCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputCheckCodeForm));
            this.lbl_Info = new System.Windows.Forms.Label();
            this.pic_CheckCode = new System.Windows.Forms.PictureBox();
            this.cbx_AutoSubmit = new System.Windows.Forms.CheckBox();
            this.tbx_CheckCode = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
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
            // pic_CheckCode
            // 
            this.pic_CheckCode.Location = new System.Drawing.Point(15, 28);
            this.pic_CheckCode.Name = "pic_CheckCode";
            this.pic_CheckCode.Size = new System.Drawing.Size(153, 58);
            this.pic_CheckCode.TabIndex = 1;
            this.pic_CheckCode.TabStop = false;
            // 
            // cbx_AutoSubmit
            // 
            this.cbx_AutoSubmit.AutoSize = true;
            this.cbx_AutoSubmit.Checked = true;
            this.cbx_AutoSubmit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_AutoSubmit.Location = new System.Drawing.Point(15, 93);
            this.cbx_AutoSubmit.Name = "cbx_AutoSubmit";
            this.cbx_AutoSubmit.Size = new System.Drawing.Size(144, 16);
            this.cbx_AutoSubmit.TabIndex = 3;
            this.cbx_AutoSubmit.Text = "输入验证码后自动回车";
            this.cbx_AutoSubmit.UseVisualStyleBackColor = true;
            // 
            // tbx_CheckCode
            // 
            this.tbx_CheckCode.Location = new System.Drawing.Point(174, 28);
            this.tbx_CheckCode.Name = "tbx_CheckCode";
            this.tbx_CheckCode.Size = new System.Drawing.Size(100, 21);
            this.tbx_CheckCode.TabIndex = 0;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(175, 62);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(99, 23);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "确 定(&Enter)";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // InputCheckCodeForm
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 116);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_CheckCode);
            this.Controls.Add(this.cbx_AutoSubmit);
            this.Controls.Add(this.pic_CheckCode);
            this.Controls.Add(this.lbl_Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputCheckCodeForm";
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
    }
}