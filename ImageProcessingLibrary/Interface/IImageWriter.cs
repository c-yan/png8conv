using System.IO;

namespace ImageProcessingLibrary.Interface
{
    public interface IImageWriter
    {
        void SaveToStream(Stream stream, PictureImage image);
    }
}
