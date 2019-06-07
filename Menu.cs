using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Menu
    {
        public static void MenuDziennika()
        {

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. priting student");
                Console.WriteLine("2. adding student");
                Console.WriteLine("3. exit");

                ConsoleKeyInfo info = Console.ReadKey();

                if (info.Key == ConsoleKey.D3) ;
                {
                    Environment.Exit(0); break;

                }
                if (info.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("In progress!");

                }
                else if (info.Key == ConsoleKey.D2) ;
                {
                    Console.WriteLine("In progress!");
                }
            }
        }

    }
}