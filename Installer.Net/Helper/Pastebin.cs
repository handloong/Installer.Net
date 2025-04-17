using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Installer.Net
{
    public class Pastebin
    {
        public static string DefaultUrl = "https://pastebin.com/raw/BqXs0rhw";


        private static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// 从指定URL获取Pastebin内容
        /// </summary>
        /// <param name="url">Pastebin原始内容URL</param>
        /// <returns>获取到的文本内容</returns>
        public static async Task<List<ApplicationInfo>> GetApplicationInfosAsync(string url)
        {
            var json = await GetContentAsync(url);
            return json.JsonFrom<List<ApplicationInfo>>();
        }


        /// <summary>
        /// 从指定URL获取Pastebin内容
        /// </summary>
        /// <param name="url">Pastebin原始内容URL</param>
        /// <returns>获取到的文本内容</returns>
        public static async Task<string> GetContentAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("URL不能为空", nameof(url));
            }

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // 确保请求成功
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"获取内容失败: {ex.Message}", ex);
            }
        }

    }
}
