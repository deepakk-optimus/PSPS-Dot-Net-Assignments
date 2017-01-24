using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press \n1. VB \n2. C# \n3. Other");
            string _choice = Console.ReadLine();

            if(_choice == "1")
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
            }
            else if(_choice == "2")
            {
                Console.WriteLine("Good choice, C# is a fine language.");
            }
            else if (_choice == "3")
            {
                Console.WriteLine("Well...good luck with that!");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.ReadKey();
        }
    }
}
