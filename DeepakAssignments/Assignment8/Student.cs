using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Student
    {
        string _name;
        string _sex;
        int _age;
        string _standard;

       public Student(string _name, string _sex, string _standard,int _age)
        {
            this._name = _name;
            this._sex = _sex;
            this._standard = _standard;
            this._age = _age;
        }

        public string Name
        {
            get { return _name; }
            set{ _name = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public string Standard
        {
            get { return _standard; }
            set { _standard = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Student GetStudent()
        {
            return new Student("Deepak","Male","B.E",24);
        }

        public int GenerateStudentEnrollmentNumber()
        {
            Random _random = new Random();
            int _randomNumber = _random.Next();
            return _randomNumber;
        }

        public static void print (Student _student)
        {
            Console.WriteLine("Welcome {0}", _student.Name);
            Console.WriteLine("Age is {0}", _student.Age);
            Console.WriteLine("Gender is {0}", _student.Sex);
            Console.WriteLine("Standard is {0}", _student.Standard);
        }

        enum StudentDetails {Name=1,Age,Gender,Standard };

        public void print(int choice)
        {
            switch (choice)
            {
                case (int)StudentDetails.Name:
                    {
                        Console.WriteLine("Name is {0}", Name);
                        break;
                    }
                case (int)StudentDetails.Age:
                    {
                        Console.WriteLine("Age is {0}", Age);
                        break;
                    }
                case (int)StudentDetails.Gender:
                    {
                        Console.WriteLine("Gender is {0}", Sex);
                        break;
                    }
                case (int)StudentDetails.Standard:
                    {
                        Console.WriteLine("Standard is {0}", Standard);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
        }
    }
}
