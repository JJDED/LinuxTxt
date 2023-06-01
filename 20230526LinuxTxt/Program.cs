// See https://aka.ms/new-console-template for more information
using _20230526LinuxTxt.Codes;

Console.WriteLine("Hello, World!");

FileHandler fh = new();

try
{
    fh.CreateFile();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
int x = 1;

while(true)
{
    Console.Clear();
    Console.WriteLine(x);
    System.Threading.Thread.Sleep(1000);
    x++;
}