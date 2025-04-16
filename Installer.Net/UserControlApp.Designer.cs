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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlAppIcon1 = new Installer.Net.UserControlAppIcon();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "浏览器";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon1);
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 47);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(226, 453);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // userControlAppIcon1
            // 
            this.userControlAppIcon1.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon1.Location = new System.Drawing.Point(3, 3);
            this.userControlAppIcon1.Name = "userControlAppIcon1";
            this.userControlAppIcon1.Size = new System.Drawing.Size(220, 55);
            this.userControlAppIcon1.TabIndex = 0;
            // 
            // UserControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "UserControlApp";
            this.Size = new System.Drawing.Size(246, 500);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UserControlAppIcon userControlAppIcon1;
    }
}
