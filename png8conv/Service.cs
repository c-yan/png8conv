using System.IO;

namespace png8conv
{
    internal static class Service
    {
        internal static string AvoidCollisionPath(string path)
        {
            if (!File.Exists(path)) return path;

            var dir = Path.GetDirectoryName(path);
            var name = Path.GetFileNameWithoutExtension(path);
            var ext = Path.GetExtension(path);

            var i = 0;
            string newPath;
            do
            {
                i++;
                newPath = $"{dir}\\{name}[{i}]{ext}";
            } while (File.Exists(newPath));
            return newPath;
        }

        internal static string ConvertToTargetPath(string sourcePath)
        {
            return Path.ChangeExtension(sourcePath, ".png");
        }
    }
}
