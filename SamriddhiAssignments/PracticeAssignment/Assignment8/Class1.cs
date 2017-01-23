using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class TestStudent
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 80, 70, 90 };
            Student _student = new Student(1, "Sam", marks);

           
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Print 1. Student id\n 2. Student name\n 3.Student Enrollment Number\n 4. Student Marks \n 5. All");
            int _choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you entered {0}", _choice);
            _student.print(_choice);
            _student.showResult();
            Console.ReadKey();
        }
    }
}
