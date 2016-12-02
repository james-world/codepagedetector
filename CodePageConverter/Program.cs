using System;
using System.IO;
using System.Text;
using CodePageDetector;

namespace CodePageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryInfo = GetDirectory(args[0]);
            if (directoryInfo == null)
                return;

            foreach (var file in directoryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                ConvertFile(file.FullName);
            }
        }

        static DirectoryInfo GetDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Console.WriteLine($"Unabled to find director {directory}");
                return null;
            }
            else
            {
                return new DirectoryInfo(directory);
            }
        }

        static void ConvertFile(string filePath)
        {
            try
            {
                var fileInfo = new FileInfo(filePath);
                var output = EncodingTools.OpenTextFile(fileInfo.FullName);
                var contents = output.ReadToEnd();
                var outputFileName = Path.Combine(fileInfo.DirectoryName, fileInfo.Name + ".txt");
                File.WriteAllText(outputFileName, contents, Encoding.UTF8);
            }
            catch (Exception)
            {
                Console.WriteLine($"Could not convert {filePath}");
            }

        }
    }
}
