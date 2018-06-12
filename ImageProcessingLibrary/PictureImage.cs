using ImageProcessingLibrary.Interface;
using System.IO;

namespace ImageProcessingLibrary
{
    public class PictureImage
    {
        public void LoadFromStream(Stream stream, IImageReader reader)
        {
            reader.LoadFromStream(stream, this);
        }

        public void LoadFromFile(string path, IImageReader reader)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                reader.LoadFromStream(fs, this);
            }
        }

        public void SaveToStream(Stream stream, IImageWriter writer)
        {
            writer.SaveToStream(stream, this);
        }

        public void SaveToFile(string path, IImageWriter writer)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                writer.SaveToStream(fs, this);
            }
        }
    }
}
