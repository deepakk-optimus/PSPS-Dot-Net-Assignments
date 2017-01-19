using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /*
     * Class level comments goes here
     * 
     */
    class TestSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter preferred language:");
            string _preferedLanguage = Console.ReadLine();

            switch(_preferedLanguage)
            {
                case "VB":
                case "vb":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "C#":
                case "c#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
