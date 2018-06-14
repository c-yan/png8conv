using ImageProcessingLibrary.Interface;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace ImageProcessingLibrary.Reader
{
    public class GenericReader : IImageReader
    {
        public void LoadFromStream(Stream stream, PictureImage image)
        {
            var i = Image.FromStream(stream);
            var bmp = new Bitmap(i);
            var bmpData = bmp.LockBits(new Rectangle(Point.Empty, i.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            image.Width = i.Width;
            image.Height = i.Height;
            image.Stride = bmpData.Stride;
            image.Data = new byte[bmpData.Stride * bmpData.Height];
            Marshal.Copy(bmpData.Scan0, image.Data, 0, image.Data.Length);
            bmp.UnlockBits(bmpData);
        }
    }
}
