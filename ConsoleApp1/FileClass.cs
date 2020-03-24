using System.IO;

namespace ConsoleApp1
{
    class FileClass
    {
        static void FileCopy()
        {
            var path = @"c:\Users\alagu\";
            //using static method
            File.Copy(@"c:\Users\alagu\Desktop\Testfile", @"c:\Users\alagu\", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //
            }
            var content = File.ReadAllBytes(path);
            //creating new Object
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //
            }
        }
    }
}
