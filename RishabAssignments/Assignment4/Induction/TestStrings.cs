using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class TestStrings
    {
        static void Main(string[] args)
        {
            //Concatenation operation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();

            string name = String.Concat(fname, " ", lname);

            Console.WriteLine("Welcome {0}", name);

            //Splitting operation
            Console.WriteLine("\n\nString Splitting");

            Console.WriteLine("Enter your address");

            string address = Console.ReadLine();

            string[] splittedAddress = address.Split(' ');

            Console.WriteLine("Address Line 1: {0}\nAddress Line 2: {1}", splittedAddress[0], splittedAddress[1]);

            //Case Conversion
            Console.WriteLine("\n\nCase Conversion");
            Console.WriteLine("Name in Upper Case: {0}\nName in Lower Case: {1}", name.ToUpper(), name.ToLower());

            //Replace operation
            //Replace i with o in name
            Console.WriteLine("\n\nReplace Operation");
            Console.WriteLine("Initial Name: {0}", name);
            Console.WriteLine("Replacing 'i' with 'o'");

            Console.WriteLine("Replaced Name: {0}", name.Replace('i', 'o'));

            //Trim operation
            Console.WriteLine("\n\nTrim Operation\nTrimming spaces in name: {0}", name.Trim());
            Console.ReadKey();

        }
    }
}
