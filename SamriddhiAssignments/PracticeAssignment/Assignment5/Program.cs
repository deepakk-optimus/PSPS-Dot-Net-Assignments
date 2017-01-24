using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class TestStrings
    {
        static void Main(string[] args)
        {
            string[] _stringArray = TestStrings.GetStringArray();

            foreach(string _val in _stringArray)
            {
                Console.Write(_val);
            }

            Console.ReadKey();
        }

        private static string[] GetStringArray()
        {
            return new string[] { "Hello ", "World!"};
        } 
    }
}
