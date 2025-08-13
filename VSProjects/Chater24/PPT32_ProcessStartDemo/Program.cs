using System.Diagnostics;
namespace PPT32_ProcessStartDemo
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
            Process.Start("Explorer.exe", "https://dotnetkorea.com")
        }
    }
}
