using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryAppx
{
    class Menu
    {
        public static void MenuShow()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. priting student");
            Console.WriteLine("2. adding student");
            Console.WriteLine("3. exit");
        }
        public static void MenuInPut()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.D3) ;
            {
                Environment.Exit(0);

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
