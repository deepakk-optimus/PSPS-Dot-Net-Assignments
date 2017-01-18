using System;

namespace Induction
{
    class Launcher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your choice!");
            int choice = 0;

            choice = int.Parse(Console.ReadLine());
            new TestSwitch().Display(choice);
            Console.ReadKey();
        }
    }
}
