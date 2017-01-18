using System;

namespace Induction
{
    class Student
    {
        private int studentEnrollmentNo;
        private string name;
        private int age;
        private string address;

        //Properties
        public int StudentEnrollmentNo
        {
            get { return studentEnrollmentNo; }
            set { studentEnrollmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Parameterized Constructor
        public Student(String name, int age, String address) 
        {
            this.StudentEnrollmentNo = randomNumberGenerator();
            this.Age = age;
            this.Name = name;
            this.address = address;
        }

        //Static Methods
        public static int randomNumberGenerator()
        {
            Random random = new Random();

            return random.Next(1,10000);
        }

        public void printDetails()
        {
            Console.WriteLine("Student Details are: \n{0}", this);
        }

        public void printDetails(int choice)
        {
            if (choice == (int)StudentAttributes.PrintAge)
            {
                Console.WriteLine("Age of {0} is {1}!", this.Name, this.Age);
            }

            else if(choice == (int)StudentAttributes.PrintDetails)
            {
                printDetails();

            }

            else
            {
                Console.WriteLine("Wrong choice");
            }
        }

        public override string ToString()
        {
            return "Enrollment No. = " + StudentEnrollmentNo + ", Name = " + Name +
                ", Age = " + Age + ", Address = " + Address;
        }

    }
}
