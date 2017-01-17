using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TestIf
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

            if (_languageOption.Equals("1"))
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
            }
            else if (_languageOption.Equals("2"))
            {
                Console.WriteLine("Good choice, C# is a fine language.");
            }
            else
            {
                Console.WriteLine("Well...good luck with that!");
            }
            Console.WriteLine("----------***************--------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
