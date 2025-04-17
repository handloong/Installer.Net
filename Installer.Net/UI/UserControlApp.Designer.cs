namespace Installer.Net
{
    partial class UserControlApp
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboApp = new System.Windows.Forms.CheckBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cboApp
            // 
            this.cboApp.BackColor = System.Drawing.Color.White;
            this.cboApp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboApp.Location = new System.Drawing.Point(34, 7);
            this.cboApp.Name = "cboApp";
            this.cboApp.Size = new System.Drawing.Size(127, 24);
            this.cboApp.TabIndex = 6;
            this.cboApp.Text = "谷歌浏览器";
            this.cboApp.UseVisualStyleBackColor = false;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Installer.Net.Properties.Resources._84;
            this.picIcon.Location = new System.Drawing.Point(4, 5);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(24, 24);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 5;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UserControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.cboApp);
            this.Name = "UserControlApp";
            this.Size = new System.Drawing.Size(164, 37);
            this.Click += new System.EventHandler(this.UserControlAppIcon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.CheckBox cboApp;
    }
}
