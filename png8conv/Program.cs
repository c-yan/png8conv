using ImageProcessingLibrary;
using ImageProcessingLibrary.Reader;
using ImageProcessingLibrary.Writer;
using System.IO;

namespace png8conv
{
    class Program
    {
        static string GetTargetPath(string sourcePath)
        {
            return Path.ChangeExtension(sourcePath, "png");
        }

        static void Main(string[] args)
        {
            var sourcePath = args[0];
            var image = new PictureImage();
            var reader = new GenericReader();
            image.LoadFromFile(sourcePath, reader);
            var writer = new PngWriter();
            image.SaveToFile(GetTargetPath(sourcePath), writer);
        }
    }
}
