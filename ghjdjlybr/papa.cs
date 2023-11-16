using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ghjdjlybr
{
    internal class papa
    {
        public static void Dirs(string hqd)
        {
            if (Directory.Exists(hqd))
            {
                while (true)
                {

                    Console.Clear();
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine(" Escape - Вернуться назад");
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("".PadRight(120, '-'));
                    Console.WriteLine($"{"Название",15} {"Дата создания",38} {"Тип",19}");
                    string[] papi = Directory.GetDirectories(hqd);
                    for (int i = 0; i < papi.Length; i++)
                    {
                        string papa = papi[i];
                        string name = Path.GetFileName(papa);
                        if (name.Length >= 25)
                        {
                            name = name.Substring(0, 25);
                        }
                        Console.Write("  " + name);
                        Console.SetCursorPosition(30, i + 3);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(papa));
                    }
                    string[] files = Directory.GetFiles(hqd);
                    for (int j = 0; j < files.Length; j++)
                    {
                        string file = files[j];
                        string fileName = Path.GetFileName(file); 

                        Console.Write("  " + fileName);

                        Console.SetCursorPosition(30, j + 3 + papi.Length);
                        string filetip = Path.GetExtension(file);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(file) + "\t\t" + filetip);
                    }
                    int pozicia = Strelki.Strelkaestzi(2, papi.Length + files.Length + 3);

                    switch (pozicia)
                    {
                        case -420:
                            return;
                    }

                    if (pozicia - 3 < papi.Length)
                        Dirs(papi[pozicia - 3]);
                    else
                        Dirs(files[pozicia - 3 - papi.Length]);
  


                }
            }
            else
            {

                Process.Start(new ProcessStartInfo { FileName = hqd, UseShellExecute = true });
            }
            
        }
    }
}
