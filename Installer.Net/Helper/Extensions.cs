using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer.Net
{
    public static class Extensions
    {
        #region BytesToString
        /// <summary>
        /// BytesToString
        /// </summary>
        /// <param name="byteCount">1024*19</param>
        /// <returns>19KB</returns>
        public static string ToStringUnit(this long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return $"{(Math.Sign(byteCount) * num).ToString(CultureInfo.InvariantCulture)} {suf[place]}";
        }
        #endregion


        public static Task WaitForExitAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<bool>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(true);

            // 如果进程已退出，直接返回完成的任务
            if (process.HasExited)
            {
                tcs.TrySetResult(true);
            }
            return tcs.Task;
        }
    }
}
