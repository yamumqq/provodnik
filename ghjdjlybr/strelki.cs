using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghjdjlybr
{
    internal class Strelki
    {
        public static int Strelkaestzi(int min, int max)
        {

            ConsoleKeyInfo key;
            int pozicia = 3;
            do
            {
                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pozicia);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow && pozicia != min)
                {
                    pozicia--;
                    if (pozicia == min)
                        pozicia = max - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow && pozicia != max)
                {
                    pozicia++;
                    if (pozicia == max)
                        pozicia = min + 1;
                }
                
                 else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -420;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    return -69;
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    return -228;
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    return -777;
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    return -52;
                }



            } while (key.Key != ConsoleKey.Enter);
            return pozicia;
        }
    }
}
