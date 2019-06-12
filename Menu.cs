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
            Console.ReadKey();
            ConsoleKeyInfo info = Console.ReadKey();


        }
        public static void MenuInPut()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.D3)
            {
                Environment.Exit(0);

            }
            if (info.Key == ConsoleKey.D1)
            {
               
                Console.WriteLine("Informations about students:");
                Student StudentOne = new Student();

                string result = $"First name: {StudentOne.firstname} Surname: {StudentOne.name} Date of birth: {StudentOne.dateofbirth} Assessment: {StudentOne.assessment}";
                Console.WriteLine(result);




            }
            else if (info.Key == ConsoleKey.D2) 
            {
                Console.WriteLine("Add informations about students:");
                Console.WriteLine("Wprowadź imię:");
                Student StudentOne = new Student();
                StudentOne.firstname = Console.ReadLine();
                Console.WriteLine("Nazwisko:");
                StudentOne.name = Console.ReadLine();
                Console.WriteLine("Data urodzenia:");
                StudentOne.dateofbirth = Console.ReadLine();
                Console.WriteLine("Wprowadź oceny:");
                List<int> assessment = new List<int>();
                StudentOne.assessment = Console.Read();

                Console.WriteLine("Wciśnij 1 jeśli chcesz dodać kolejnego studenta");
                Console.WriteLine("Wciśnij 2 jeśli chcesz wrócić do menu");
                Console.ReadKey();
                ConsoleKeyInfo number = Console.ReadKey();


                if (number.Key == ConsoleKey.D1)
                {
                    Student StudentSecond = new Student();
                    StudentSecond.firstname = Console.ReadLine();
                    Console.WriteLine("Nazwisko:");
                    StudentSecond.name = Console.ReadLine();
                    Console.WriteLine("Data urodzenia:");
                    StudentSecond.dateofbirth = Console.ReadLine();
                    Console.WriteLine("Wprowadź oceny:");
                    List<int> assessmentsecond = new List<int>();
                    StudentSecond.assessment = Console.Read();
                }
                if (number.Key == ConsoleKey.D2)
                {
                    Menu.MenuShow();
                }
            }
        }   
    }
}
