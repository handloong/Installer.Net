using Installer.Net.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Net
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            flowLayoutPanel.WrapContents = true; // 确保允许换行
            flowLayoutPanel.AutoSize = true;     // 自动调整大小
            flowLayoutPanel.AutoScroll = true;

            this.Text += $" v{AssemblyVersion}";

            toolTip.AutoPopDelay = 5000;  // 提示显示持续时间（毫秒）
            toolTip.InitialDelay = 500;    // 鼠标悬停多久后显示提示
            toolTip.ReshowDelay = 500;     // 移动鼠标后重新显示提示的延迟
            toolTip.ShowAlways = true;     // 即使窗体不活动也显示提示
            toolTip.BackColor = Color.LightYellow;
            toolTip.ForeColor = Color.Black;
            toolTip.IsBalloon = true;     
        }

        private ToolTip toolTip = new ToolTip();
        private async Task InitializeTableControlAsync(string url)
        {
            try
            {
                Font checkBoxFont;
                if (FontFamily.Families.Any(f => f.Name == "Microsoft YaHei UI"))
                    checkBoxFont = new Font("Microsoft YaHei UI", 11f);
                else
                    checkBoxFont = new Font("Arial", 11f);

                var applicationInfos = await Pastebin.GetApplicationInfosAsync(url);
                flowLayoutPanel.Controls.Clear();

                foreach (var item in applicationInfos)
                {
                    var cb = new CheckBox();
                    cb.Tag = item;
                    cb.Text = item.Name;
                    cb.Checked = item.Checked;
                    cb.AutoSize = true;
                    cb.Font = checkBoxFont;
                    toolTip.SetToolTip(cb, item.Description);

                    flowLayoutPanel.Controls.Add(cb);
                }
            }
            catch (Exception ex)
            {
                lblLoading.Text = ex.Message;
                lblLoading.ForeColor = Color.Red;
                lblLoading.Show();
            }
        }


        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await InitializeTableControlAsync(Pastebin.DefaultUrl);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loadConfigJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 开源地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/handloong/Installer.Net");
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox cb)
                {
                    cb.Checked = true;
                }
            }
        }

        private void 反选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox cb)
                {
                    cb.Checked = !cb.Checked;
                }
            }
        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLoadJson(async x =>
            {
                await InitializeTableControlAsync(x);
            }).ShowDialog();
        }

        private void 安装ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ApplicationInfo> apps = new List<ApplicationInfo>();

            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox cb && cb.Checked)
                {
                    apps.Add(cb.Tag as ApplicationInfo);
                }
            }

            if (apps.Any())
            {
                string appNames = string.Join("\n", apps.Select(a => $"• {a.Name}"));
                string message = $"您确定要安装以下 {apps.Count} 个应用程序吗？\n\n{appNames}";

                var result = MessageBox.Show(
                    message,
                    "确认安装",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    new FrmInstalling(apps).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "请至少勾选一个要安装的程序",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
