namespace Tuan.WinForm
{
    partial class SettingForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_localDB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_serverDB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_localDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_serverDB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_cancel);
            this.groupControl1.Controls.Add(this.btn_save);
            this.groupControl1.Controls.Add(this.textEdit_localDB);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_serverDB);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(503, 176);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "配置";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 129);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取 消(&E)";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(320, 129);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保 存(&S)";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textEdit_localDB
            // 
            this.textEdit_localDB.Location = new System.Drawing.Point(117, 87);
            this.textEdit_localDB.Name = "textEdit_localDB";
            this.textEdit_localDB.Size = new System.Drawing.Size(374, 21);
            this.textEdit_localDB.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "  本地DB链接串：";
            // 
            // textEdit_serverDB
            // 
            this.textEdit_serverDB.Location = new System.Drawing.Point(117, 43);
            this.textEdit_serverDB.Name = "textEdit_serverDB";
            this.textEdit_serverDB.Size = new System.Drawing.Size(374, 21);
            this.textEdit_serverDB.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "服务器DB链接串：";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 176);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "配置地址";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_localDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_serverDB.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_serverDB;
        private DevExpress.XtraEditors.TextEdit textEdit_localDB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_save;
    }
}