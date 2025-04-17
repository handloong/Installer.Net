using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Installer.Net
{
    public partial class FrmInstalling : Form
    {
        private readonly List<ApplicationInfo> _applicationInfos;

        public FrmInstalling(List<ApplicationInfo> applicationInfos)
        {
            InitializeComponent();
            _applicationInfos = applicationInfos;
        }

        private async void FrmInstalling_Load(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            for (int i = 0; i < _applicationInfos.Count; i++)
            {
                var item = _applicationInfos[i];
                while (true)
                {
                    if (progressBar1.Value == 100)
                    {
                        this.Text = $"[{item.Name}]下载完成,安装中...";
                        await Task.Delay(3000);
                        if (i == _applicationInfos.Count - 1)
                        {
                            MessageBox.Show($"所有软件安装完成");
                            this.Close();
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                        break;
                    }
                    else
                    {
                        progressBar1.PerformStep();
                        this.Text = $"正在下载[{item.Name}]...";
                    }
                    await Task.Delay(1);
                }
            }
        }
    }
}
