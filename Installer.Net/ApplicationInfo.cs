namespace Installer.Net
{
    public class ApplicationInfo
    {
        /// <summary>
        /// 注意:这个是软件写入版本
        /// </summary>
        public string Version { get; set; }

        public string Category { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DownloadUrl { get; set; }
        public string Type { get; set; }
        public string BeginInstallParams { get; set; }
        public string AfterInstallParams { get; set; }
    }
}
