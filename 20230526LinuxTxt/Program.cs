// See https://aka.ms/new-console-template for more information
using _20230526LinuxTxt.Codes;

FileHandler fh = new();

try
{
    fh.CreateFile();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
