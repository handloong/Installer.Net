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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSoftListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControlAppIcon1 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon2 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon3 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon4 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon5 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon6 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon7 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon8 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon9 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon10 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon11 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon12 = new Installer.Net.UserControlAppIcon();
            this.userControlAppIcon13 = new Installer.Net.UserControlAppIcon();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.选中ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSoftListToolStripMenuItem,
            this.loadConfigJsonToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // makeSoftListToolStripMenuItem
            // 
            this.makeSoftListToolStripMenuItem.Name = "makeSoftListToolStripMenuItem";
            this.makeSoftListToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.makeSoftListToolStripMenuItem.Text = "创建配置";
            // 
            // loadConfigJsonToolStripMenuItem
            // 
            this.loadConfigJsonToolStripMenuItem.Name = "loadConfigJsonToolStripMenuItem";
            this.loadConfigJsonToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.loadConfigJsonToolStripMenuItem.Text = "加载配置";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon1);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon2);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon3);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon4);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon5);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon6);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon7);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon8);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon9);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon10);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon11);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon12);
            this.flowLayoutPanel.Controls.Add(this.userControlAppIcon13);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(781, 518);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // 选中ToolStripMenuItem
            // 
            this.选中ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.unSelectAllToolStripMenuItem});
            this.选中ToolStripMenuItem.Name = "选中ToolStripMenuItem";
            this.选中ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.选中ToolStripMenuItem.Text = "选中";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectAllToolStripMenuItem.Text = "全选";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // unSelectAllToolStripMenuItem
            // 
            this.unSelectAllToolStripMenuItem.Name = "unSelectAllToolStripMenuItem";
            this.unSelectAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unSelectAllToolStripMenuItem.Text = "反选";
            this.unSelectAllToolStripMenuItem.Click += new System.EventHandler(this.unSelectAllToolStripMenuItem_Click);
            // 
            // userControlAppIcon1
            // 
            this.userControlAppIcon1.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon1.Location = new System.Drawing.Point(3, 3);
            this.userControlAppIcon1.Name = "userControlAppIcon1";
            this.userControlAppIcon1.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon1.TabIndex = 0;
            // 
            // userControlAppIcon2
            // 
            this.userControlAppIcon2.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon2.Location = new System.Drawing.Point(184, 3);
            this.userControlAppIcon2.Name = "userControlAppIcon2";
            this.userControlAppIcon2.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon2.TabIndex = 1;
            // 
            // userControlAppIcon3
            // 
            this.userControlAppIcon3.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon3.Location = new System.Drawing.Point(365, 3);
            this.userControlAppIcon3.Name = "userControlAppIcon3";
            this.userControlAppIcon3.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon3.TabIndex = 2;
            // 
            // userControlAppIcon4
            // 
            this.userControlAppIcon4.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon4.Location = new System.Drawing.Point(546, 3);
            this.userControlAppIcon4.Name = "userControlAppIcon4";
            this.userControlAppIcon4.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon4.TabIndex = 3;
            // 
            // userControlAppIcon5
            // 
            this.userControlAppIcon5.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon5.Location = new System.Drawing.Point(3, 46);
            this.userControlAppIcon5.Name = "userControlAppIcon5";
            this.userControlAppIcon5.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon5.TabIndex = 4;
            // 
            // userControlAppIcon6
            // 
            this.userControlAppIcon6.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon6.Location = new System.Drawing.Point(184, 46);
            this.userControlAppIcon6.Name = "userControlAppIcon6";
            this.userControlAppIcon6.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon6.TabIndex = 5;
            // 
            // userControlAppIcon7
            // 
            this.userControlAppIcon7.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon7.Location = new System.Drawing.Point(365, 46);
            this.userControlAppIcon7.Name = "userControlAppIcon7";
            this.userControlAppIcon7.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon7.TabIndex = 6;
            // 
            // userControlAppIcon8
            // 
            this.userControlAppIcon8.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon8.Location = new System.Drawing.Point(546, 46);
            this.userControlAppIcon8.Name = "userControlAppIcon8";
            this.userControlAppIcon8.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon8.TabIndex = 7;
            // 
            // userControlAppIcon9
            // 
            this.userControlAppIcon9.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon9.Location = new System.Drawing.Point(3, 89);
            this.userControlAppIcon9.Name = "userControlAppIcon9";
            this.userControlAppIcon9.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon9.TabIndex = 8;
            // 
            // userControlAppIcon10
            // 
            this.userControlAppIcon10.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon10.Location = new System.Drawing.Point(184, 89);
            this.userControlAppIcon10.Name = "userControlAppIcon10";
            this.userControlAppIcon10.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon10.TabIndex = 9;
            // 
            // userControlAppIcon11
            // 
            this.userControlAppIcon11.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon11.Location = new System.Drawing.Point(365, 89);
            this.userControlAppIcon11.Name = "userControlAppIcon11";
            this.userControlAppIcon11.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon11.TabIndex = 10;
            // 
            // userControlAppIcon12
            // 
            this.userControlAppIcon12.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon12.Location = new System.Drawing.Point(546, 89);
            this.userControlAppIcon12.Name = "userControlAppIcon12";
            this.userControlAppIcon12.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon12.TabIndex = 11;
            // 
            // userControlAppIcon13
            // 
            this.userControlAppIcon13.BackColor = System.Drawing.Color.White;
            this.userControlAppIcon13.Location = new System.Drawing.Point(3, 132);
            this.userControlAppIcon13.Name = "userControlAppIcon13";
            this.userControlAppIcon13.Size = new System.Drawing.Size(175, 37);
            this.userControlAppIcon13.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 546);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Installer.Net / 自动安装器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSoftListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigJsonToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem 选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSelectAllToolStripMenuItem;
        private UserControlAppIcon userControlAppIcon1;
        private UserControlAppIcon userControlAppIcon2;
        private UserControlAppIcon userControlAppIcon3;
        private UserControlAppIcon userControlAppIcon4;
        private UserControlAppIcon userControlAppIcon5;
        private UserControlAppIcon userControlAppIcon6;
        private UserControlAppIcon userControlAppIcon7;
        private UserControlAppIcon userControlAppIcon8;
        private UserControlAppIcon userControlAppIcon9;
        private UserControlAppIcon userControlAppIcon10;
        private UserControlAppIcon userControlAppIcon11;
        private UserControlAppIcon userControlAppIcon12;
        private UserControlAppIcon userControlAppIcon13;
    }
}

