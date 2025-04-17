﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            flowLayoutPanel.Controls.Clear();

            foreach (var item in applicationInfos)
            {
                var app = new UserControlApp(item);
                flowLayoutPanel.Controls.Add(app);
            }

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
            InitializeTableControl("");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlApp)
                {
                    (item as UserControlApp).SelectAll();
                }
            }
        }

        private void unSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlApp)
                {
                    (item as UserControlApp).UnSelectAll();
                }
            }
        }

        private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ApplicationInfo> apps = new List<ApplicationInfo>();

            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlApp)
                {
                    var app = (item as UserControlApp);
                    if (app.Checked)
                    {
                        apps.Add(app.ApplicationInfo);
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
