using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace rabotat_screenshooter
{
    class Program
    {
        static public string path = @"";
        static void Main(string[] args)
        {
            if (args.Length > 0) {
                path = args[0];
            }

            path = Path.Combine(path, Environment.UserName.ToLower() + "@" + Environment.UserDomainName.ToLower());
            path = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd"));

            DirectoryInfo di = Directory.CreateDirectory(path);

            var imageName = Path.Combine(path,
                Environment.UserName.ToLower() + "@" +
                Environment.UserDomainName.ToLower() + "_" +
                DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "_" +
                Environment.MachineName.ToLower() + ".png");

            Image screen = Pranas.ScreenshotCapture.TakeScreenshot();
            screen.Save(imageName, ImageFormat.Png);
        }
    }
}
