using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace rabotat_screenshooter
{
    class Program
    {
        static public string path = "";
        static void Main(string[] args)
        {
            
            if (args.Length > 0) {
                path = args[0];
            }

            var imageName = Path.Combine(path,
                Environment.UserName.ToLower() + "_" +
                Environment.UserDomainName.ToLower() + "_" +
                Environment.MachineName.ToLower() + "_" +
                DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png");

            Image screen = Pranas.ScreenshotCapture.TakeScreenshot();
            screen.Save(imageName, ImageFormat.Png);
        }
    }
}
