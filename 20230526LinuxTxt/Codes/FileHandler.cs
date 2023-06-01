using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230526LinuxTxt.Codes;

internal class FileHandler
{
    //Update på Linux
    //public string FileName { get; set; }
    //public string MyUserDir { get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), FileName }
    //public FileHandler(string fileName) => FileName = fileName;
    public bool CreateFile() // => File.Create(MyUserDir)
    {
        bool success = true;

        try
        {
            // C:\\Users\Users\Jamie
            string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            File.Create(Path.Combine(myUserFolder, "test.txt"));
            //File.Create();
            Console.WriteLine("File created");
        }
        catch (Exception)
        {
            success = false;
            Console.WriteLine("File could not create");
        }

        return success;
    }
}
