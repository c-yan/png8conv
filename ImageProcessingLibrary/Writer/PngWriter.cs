using ImageProcessingLibrary.Interface;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ImageProcessingLibrary.Writer
{
    public class PngWriter : IImageWriter
    {
        public void SaveToStream(Stream stream, PictureImage image)
        {
            var bmp = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
            var bmpData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(image.Data, 0, bmpData.Scan0, image.Data.Length);
            bmp.UnlockBits(bmpData);
            bmp.Save(stream, ImageFormat.Png);
        }
    }
}
