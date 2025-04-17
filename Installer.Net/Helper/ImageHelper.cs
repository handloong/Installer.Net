using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer.Net
{
    public class ImageHelper
    {
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // 将图片保存到内存流中
                image.Save(ms, format);
                // 将内存流转换为字节数组，再转为 Base64
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            try
            {
                // 将 Base64 字符串转换为字节数组
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // 从内存流创建 Image 对象
                    return Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                //return Properties.Resources._84;
                return null;
            }
        }
    }
}
