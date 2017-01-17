using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace Assignment8
{
    class Proram
    {
        static void Main(string[] args)
        {
            Student _student = new Student("Shubham","Male","B.E",24);
             int _enrollmentNumber = _student.GenerateStudentEnrollmentNumber();
             Console.WriteLine("Enrollment  Number is {0}", _enrollmentNumber);
             Student.print(_student);
             _student.print(2);
             Console.ReadKey();
             

           /* NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            Console.WriteLine(nc1(5));
            Console.WriteLine(nc2(6));
            Console.ReadKey();*/

        }

        public static int AddNum(int num)
        {
            return num + 1;
        }

        public static int MultNum(int num)
        {
            return num * 5;
        }

        

        


    }
}
