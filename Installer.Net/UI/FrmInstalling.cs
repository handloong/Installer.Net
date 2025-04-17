using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void FrmInstalling_Load(object sender, EventArgs ea)
        {
            progressBar.Step = 1;
            string tempPath = Path.Combine(Path.GetTempPath(), "Installer.Net");
            Directory.CreateDirectory(tempPath);
            int successful = 0;
            for (int i = 0; i < _applicationInfos.Count; i++)
            {
                var item = _applicationInfos[i];
                string appFullName = Path.Combine(tempPath, $"{Guid.NewGuid()}.{item.Type}");

                try
                {
                    //解决部分网站错误: 请求被中止: 未能创建 SSL/TLS 安全通道
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    using (var client = new WebClient())
                    {
                        client.DownloadProgressChanged += (s, e) =>
                        {
                            progressBar.Value = e.ProgressPercentage;
                            lblSpeed.Text = $"[{item.Name}] {e.BytesReceived.ToStringUnit()} / {e.TotalBytesToReceive.ToStringUnit()}";
                        };
                        await client.DownloadFileTaskAsync(new Uri(item.DownloadUrl), appFullName);
                    }
                    lblSpeed.Text = $"[{item.Name}] 下载完成,安装中...";

                    if (item.Type == "msi")
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = $"/i \"{appFullName}\" {item.Params}";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        await process.WaitForExitAsync();
                    }
                    else
                    {
                        Process process = new Process();
                        process.StartInfo.FileName = appFullName;
                        process.StartInfo.Arguments = item.Params;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        await process.WaitForExitAsync();
                    }

                    if (!string.IsNullOrEmpty(item.AfterInstallParams))
                    {
                        lblSpeed.Text = "执行安装后命令...";
                        Process afterProcess = new Process();
                        afterProcess.StartInfo.FileName = "cmd.exe";
                        afterProcess.StartInfo.Arguments = $"/C {item.AfterInstallParams}";
                        afterProcess.StartInfo.UseShellExecute = false;
                        afterProcess.StartInfo.CreateNoWindow = true;
                        afterProcess.Start();
                        await afterProcess.WaitForExitAsync();
                    }

                    lblSpeed.Text = "删除安装包...";
                    bool fileDeleted = false;
                    while (!fileDeleted)
                    {
                        try
                        {
                            File.Delete(appFullName);
                            fileDeleted = true;
                        }
                        catch
                        {
                            await Task.Delay(1000);
                        }
                    }
                    successful++;
                }
                catch (Exception ex)
                {

                }

                if (_applicationInfos.Count == i + 1)
                {
                    lblSpeed.Text = $"安装完成,共安装成功{successful}个";
                    this.Text = "";
                }
            }
        }
    }
}
