using System.IO;

namespace DotNetTutorial
{
    public static class WorkingWithFiles
    {
        public static void Call()
        {
            // security checking while using File static methods
            const string path = @"c:\\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\myfile2.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            File.ReadAllText(path);
            File.ReadAllBytes(path);
            
            // File info
            
            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo(path);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            var read = fileInfo.OpenRead();
        }
    }
}