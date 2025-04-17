using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        }

        private void InitializeTableControl(string fileName)
        {
            var applicationInfos = LoadApplicationInfos();

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

        private List<ApplicationInfo> LoadApplicationInfos()
        {
            return new List<ApplicationInfo>
            {
                new ApplicationInfo{
                      Name ="mRemoteNG",
                      DownloadUrl="http://10.32.44.80:8006/Soft/Installer.Net/mRemoteNG-Installer-1.77.3.nb-1784.msi",
                      Type ="msi",
                      Params ="/passive",
                },
                new ApplicationInfo{
                      Name ="bandizip无广告",
                       DownloadUrl="http://10.32.44.80:8006/Soft/Installer.Net/BANDIZIP6-SETUP.exe",
                      Type="exe",
                      Params ="/S",
                },
                new ApplicationInfo{
                      Name ="微信",
                      DownloadUrl="http://10.32.44.80:8006/Soft/Installer.Net/WeChatWin.exe",
                      Type="exe",
                      Params ="/S",
                }
            };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeTableControl("");
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
    }
}
