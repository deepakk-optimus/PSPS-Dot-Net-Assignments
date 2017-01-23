using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    enum StudentAttribute
    {
        StudentId = 1, StudentName, StudentEnrollmentNumber, StudentMarks
    };

    class Student
    {
        private int _sid;
        private string _name;
        private int[] _marks;
        private int _studentEnrollmentNumber;

        public Student (int sid, string name, int[] marks)
        {
            _sid = sid;
            _name = name;
            _marks = marks;
            _studentEnrollmentNumber = GenerateEnrollmentNumber();
        }
        
        public int Id
        {
            get
            {
                return _sid;
            }
            set
            {
                _sid = value;
            }
        } 

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int[] Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                _marks = value;
            }
        }

        public int StudentEnrollmentNumber
        {
            get
            {
                return _studentEnrollmentNumber;
            }
        }

        private int GenerateEnrollmentNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber;
        }

        public double showResult()
        {
            int sum = 0;
            if(_marks.Length == 0)
            {
                return 0;
            }
            foreach(int val in _marks) {
                sum += val;
            }
            return (sum/(_marks.Length));
        }

        private void print()
        {
            Console.WriteLine("Welcome to Student Details Page");
            Console.WriteLine("Student id : {0}", _sid);
            Console.WriteLine("Name : {0}", _name);
            Console.WriteLine("Enrollment Number : {0}", _studentEnrollmentNumber);
            int _count = 0;
            foreach (int val in _marks)
            {
                Console.WriteLine("Marks Subject {0}: {1}",_count++, val);
            }
        }

        public void print(int choice)
        {
            switch(choice)
            {
                case (int)StudentAttribute.StudentId:
                    Console.WriteLine("Student id : {0}", _sid);
                    break;
                case (int)StudentAttribute.StudentName:
                    Console.WriteLine("Name : {0}", _name);
                    break;
                case (int)StudentAttribute.StudentEnrollmentNumber:
                    Console.WriteLine("Enrollment Number : {0}", _studentEnrollmentNumber);
                    break;
                case (int)StudentAttribute.StudentMarks:
                    int _count = 0;
                    foreach (int val in _marks)
                    {
                        Console.WriteLine("Marks Subject {0}: {1}", _count++, val);
                    }
                    break;
                case 5:
                    print();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
