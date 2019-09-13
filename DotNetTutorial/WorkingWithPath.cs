using System;
using System.IO;

namespace DotNetTutorial
{
    public class WorkingWithPath
    {
        public static void Call()
        {
            var path = @"C:\Users\sekar\source\repos\DotNetTutorial\DotNetTutorial.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("FileName: {0}", Path.GetFileName(path));
            Console.WriteLine("FileName without extension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Dirname: {0}", Path.GetDirectoryName(path));
        }
    }
}