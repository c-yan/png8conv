using ImageProcessingLibrary;
using ImageProcessingLibrary.Reader;
using ImageProcessingLibrary.Writer;

namespace png8conv
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = args[0];
            var image = new PictureImage();
            var reader = new GenericReader();
            image.LoadFromFile(sourcePath, reader);
            var writer = new PngWriter();
            image.SaveToFile(Service.ConvertToTargetPath(sourcePath), writer);
        }
    }
}
