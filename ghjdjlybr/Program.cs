using System;

namespace ghjdjlybr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"{"Этот компьютер",60}");
                    Console.WriteLine("".PadRight(120, '-'));

                    Console.SetCursorPosition(0, 2);
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine("  " + drive.TotalSize / 1073741824 + " Гб   Cвободно: " + drive.TotalFreeSpace / 1073741824 + " ГБ ");
                    }

                    int pos = Strelki.Strelkaestzi(1, drives.Length + 2);

                    papa.Dirs(drives[pos - 2].Name);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}