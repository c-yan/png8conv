using System.IO;

namespace png8conv
{
    internal static class Service
    {
        internal static string ConvertToTargetPath(string sourcePath)
        {
            return Path.ChangeExtension(sourcePath, ".png");
        }
    }
}
