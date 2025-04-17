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
        }

        private async Task InitializeTableControlAsync(string url)
        {
            try
            {
                var applicationInfos = await Pastebin.GetApplicationInfosAsync(url);
                flowLayoutPanel.Controls.Clear();

                foreach (var item in applicationInfos)
                {
                    var cb = new CheckBox();
                    cb.Tag = item;
                    cb.Text = item.Name;
                    cb.Checked = item.Checked;
                    cb.AutoSize = true;
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
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox)
                {
                    (item as CheckBox).Checked = true;
                }
            }
        }

        private void unSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox)
                {
                    var cb = (item as CheckBox);
                    cb.Checked = !cb.Checked;
                }
            }
        }

        private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ApplicationInfo> apps = new List<ApplicationInfo>();

            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is CheckBox)
                {
                    var cb = (item as CheckBox);
                    if (cb.Checked)
                    {
                        apps.Add(cb.Tag as ApplicationInfo);
                    }
                }
            }
            if (apps.Any())
            {
                new FrmInstalling(apps).ShowDialog();
            }
            else
            {
                MessageBox.Show("未选中任何程序");
            }
        }

        private void loadConfigJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLoadJson(async x =>
            {
                await InitializeTableControlAsync(x);
            }).ShowDialog();
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
    }
}
