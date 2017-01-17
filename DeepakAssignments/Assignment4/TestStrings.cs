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
            string _nameDetail = @"Hello, I am Deepak";
            string _profile = @"Working as Java Devloper";

            Console.WriteLine(_nameDetail.Equals(_profile));
            Console.WriteLine(_nameDetail.Substring(4));
            
            string[] _names = GetStringArray();

            foreach(string _name in _names)
            {
                Console.WriteLine(_name);
            }

            Console.ReadKey();

        }


        static string[] GetStringArray()
        {
            string[] _names = {"Hello","hiii","Deepak","Shubham","Sam","Mixi","Rishab","Sir ji" };

            return _names;
        }
    }
}
