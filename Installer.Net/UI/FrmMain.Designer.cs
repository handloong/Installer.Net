namespace Installer.Net
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.安装ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开源地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者HandLoongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.临时文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.反选ToolStripMenuItem,
            this.安装ToolStripMenuItem,
            this.其他ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(90, 546);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_草莓;
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.配置ToolStripMenuItem.Text = "配置";
            this.配置ToolStripMenuItem.Click += new System.EventHandler(this.配置ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_大葱;
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 反选ToolStripMenuItem
            // 
            this.反选ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_火龙果;
            this.反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
            this.反选ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.反选ToolStripMenuItem.Text = "反选";
            this.反选ToolStripMenuItem.Click += new System.EventHandler(this.反选ToolStripMenuItem_Click);
            // 
            // 安装ToolStripMenuItem
            // 
            this.安装ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_樱桃;
            this.安装ToolStripMenuItem.Name = "安装ToolStripMenuItem";
            this.安装ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.安装ToolStripMenuItem.Text = "安装";
            this.安装ToolStripMenuItem.Click += new System.EventHandler(this.安装ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开源地址ToolStripMenuItem,
            this.作者HandLoongToolStripMenuItem});
            this.关于ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_蓝莓;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 开源地址ToolStripMenuItem
            // 
            this.开源地址ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_蓝莓;
            this.开源地址ToolStripMenuItem.Name = "开源地址ToolStripMenuItem";
            this.开源地址ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.开源地址ToolStripMenuItem.Text = "开源地址";
            this.开源地址ToolStripMenuItem.Click += new System.EventHandler(this.开源地址ToolStripMenuItem_Click);
            // 
            // 作者HandLoongToolStripMenuItem
            // 
            this.作者HandLoongToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_蓝莓;
            this.作者HandLoongToolStripMenuItem.Name = "作者HandLoongToolStripMenuItem";
            this.作者HandLoongToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.作者HandLoongToolStripMenuItem.Text = "作者-HandLoong";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.lblLoading);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(90, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(691, 546);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(3, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(79, 15);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Loading..";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.临时文件夹ToolStripMenuItem});
            this.其他ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_茄子;
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 临时文件夹ToolStripMenuItem
            // 
            this.临时文件夹ToolStripMenuItem.Image = global::Installer.Net.Properties.Resources._110_茄子;
            this.临时文件夹ToolStripMenuItem.Name = "临时文件夹ToolStripMenuItem";
            this.临时文件夹ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.临时文件夹ToolStripMenuItem.Text = "临时文件夹";
            this.临时文件夹ToolStripMenuItem.Click += new System.EventHandler(this.临时文件夹ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 546);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer.Net / 小老鼠软件安装器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开源地址ToolStripMenuItem;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ToolStripMenuItem 安装ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者HandLoongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 临时文件夹ToolStripMenuItem;
    }
}

