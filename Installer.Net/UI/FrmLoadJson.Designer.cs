namespace Installer.Net.UI
{
    partial class FrmLoadJson
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.linkLabelIct = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(13, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(497, 25);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://pastebin.com/raw/BqXs0rhw";
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(435, 56);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(75, 31);
            this.btnInvoke.TabIndex = 1;
            this.btnInvoke.Text = "确认";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // linkLabelIct
            // 
            this.linkLabelIct.AutoSize = true;
            this.linkLabelIct.Location = new System.Drawing.Point(12, 64);
            this.linkLabelIct.Name = "linkLabelIct";
            this.linkLabelIct.Size = new System.Drawing.Size(67, 15);
            this.linkLabelIct.TabIndex = 2;
            this.linkLabelIct.TabStop = true;
            this.linkLabelIct.Text = "使用内网";
            this.linkLabelIct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelIct_LinkClicked);
            // 
            // FrmLoadJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 99);
            this.Controls.Add(this.linkLabelIct);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLoadJson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.LinkLabel linkLabelIct;
    }
}