using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TestStrings
    {
        static void Main(string[] args)
        {
            string _firstString = "hello";
            string _secondString = "hello";
            string _thirdString = "HELLO";

            if (_firstString == _secondString)
            {
                Console.WriteLine("_firstString == _secondString");
            }
            if(_firstString.Equals(_secondString))
            {
                Console.WriteLine("_firstString.Equals(_secondString)");
            }
            if (_firstString.Equals(_thirdString, StringComparison.OrdinalIgnoreCase));
            {
                Console.WriteLine("_firstString.Equals(_thirdString, StringComparison.OrdinalIgnoreCase");
            }
            Console.ReadKey();
        }
    }
}
