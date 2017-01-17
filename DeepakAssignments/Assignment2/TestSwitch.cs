using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TestSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your language");
            Console.WriteLine("\n");
            Console.WriteLine("----------***************--------------");
            Console.WriteLine("Press 1 for VB.net");
            Console.WriteLine("Press 2 for C#");
            Console.WriteLine("----------***************--------------");
            string _languageOption = Console.ReadLine();
            Console.WriteLine("You Choose {0}", _languageOption);

            switch (_languageOption)
            {
                case "1":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "2":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default :
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            
            Console.WriteLine("----------***************--------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
