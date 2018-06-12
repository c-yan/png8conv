using System.IO;

namespace ImageProcessingLibrary.Interface
{
    public interface IImageReader
    {
        void LoadFromStream(Stream stream, PictureImage image);
    }
}
