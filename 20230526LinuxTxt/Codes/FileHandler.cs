using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230526LinuxTxt.Codes;

internal class FileHandler
{
    public bool CreateFile()
    {
        bool success = true;

        try
        {
            
            string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            File.Create(Path.Combine(myUserFolder, "test.txt"));            
            Console.WriteLine("File created");
        }
        catch (Exception)
        {
            success = false;
            Console.WriteLine("File could not be created");
        }

        return success;
    }
}
