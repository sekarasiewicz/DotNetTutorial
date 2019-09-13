using System;
using System.IO;

namespace DotNetTutorial
{
    public static class WorkingWithDirectories
    {
        public static void Call()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var aiFiles = Directory.GetFiles(@"C:\sebastian\AI", "*.*", SearchOption.AllDirectories);

            foreach (var file in aiFiles)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\sebastian", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine("Directory: {0}", directory);
            }

            Directory.Exists("");

            var dInfo = new DirectoryInfo("");

            dInfo.GetFiles();
            dInfo.GetDirectories();
        }
    }
}