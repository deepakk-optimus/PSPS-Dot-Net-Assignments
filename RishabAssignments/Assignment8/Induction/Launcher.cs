using System;

namespace Induction
{
    class Launcher
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rishab", 23, "A043 Noida");

            Console.WriteLine("Provide your choice:\n1. Print Age of Student\n2. Print all details");
            int choice = int.Parse(Console.ReadLine());

            student.printDetails(choice);

            Console.ReadKey();
        }
    }
}
