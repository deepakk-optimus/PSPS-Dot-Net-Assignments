using System;

namespace Induction
{
    class TestSwitch
    {
        public void Display(int choice)
        {
            switch(choice)
            {
                case 1:
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;

                case 2:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }
    }
}
