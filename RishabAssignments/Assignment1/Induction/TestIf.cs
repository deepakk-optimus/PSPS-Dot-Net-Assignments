using System;

namespace Induction
{
    class TestIf
    {
        public void Display(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");

            } else if (choice == 2)
            {
                Console.WriteLine("Good choice, C# is a fine language.");
            } else
            {
                Console.WriteLine("Well...good luck with that!");
            }
        }
    }
}
