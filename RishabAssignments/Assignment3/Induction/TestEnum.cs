using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class TestEnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Day is " + Weekdays.Sunday);
                    break;
                case 2:
                    Console.WriteLine("Day is " + Weekdays.Monday);
                    break;
                case 3:
                    Console.WriteLine("Day is " + Weekdays.Tuesday);
                    break;
                case 4:
                    Console.WriteLine("Day is " + Weekdays.Wednesday);
                    break;
                case 5:
                    Console.WriteLine("Day is " + Weekdays.Thursday);
                    break;
                case 6:
                    Console.WriteLine("Day is " + Weekdays.Friday);
                    break;
                case 7:
                    Console.WriteLine("Day is " + Weekdays.Saturday);
                    break;
                default:
                    Console.WriteLine("Wrong day no.");
                    break;

            }

            Console.ReadKey();
                
        }
    }

    enum Weekdays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    };
}
