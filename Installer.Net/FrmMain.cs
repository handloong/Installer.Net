using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Installer.Net
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void InitializeTableControl(string fileName)
        {
            var applicationInfos = LoadApplicationInfos();


        }

        private List<ApplicationInfo> LoadApplicationInfos()
        {
            return new List<ApplicationInfo>
            {
                new ApplicationInfo{
                     Category ="浏览器",
                      Name ="谷歌浏览器"
                },
                new ApplicationInfo{
                     Category ="专属",
                      Name ="bandizip"
                },
                new ApplicationInfo{
                     Category ="专属",
                      Name ="微信"
                },
                new ApplicationInfo{
                     Category ="专属",
                      Name ="ToDesk"
                },
                new ApplicationInfo{
                     Category ="专属",
                      Name ="火绒安全软件"
                }
            };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlAppIcon)
                {
                    (item as UserControlAppIcon).SelectAll();
                }
            }
        }

        private void unSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlAppIcon)
                {
                    (item as UserControlAppIcon).UnSelectAll();
                }
            }
        }
    }
}
