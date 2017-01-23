using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class StringArray
    {
        static void Main(string[] args)
        {
            String[] names = GetStringArray();

            foreach(String name in names)
            {
                Console.WriteLine("{0}", name);
            }

            Console.ReadKey();
        }

        public static String[] GetStringArray()
        {
            String[] names = { "Rishab", "Shivansh", "Aditya" };

            return names;
        }
    }
}
