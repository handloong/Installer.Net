namespace Installer.Net
{
    public class ApplicationInfo
    {
        /// <summary>
        /// 注意:这个是软件写入版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 暂时不用
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 自动选中
        /// </summary>
        public bool AutoSelect { get; set; }

        public string Name { get; set; }
        public string Icon { get; set; }
        public string DownloadUrl { get; set; }
        public string Type { get; set; }
        public string BeginInstallParams { get; set; }
        public string AfterInstallParams { get; set; }
    }
}
