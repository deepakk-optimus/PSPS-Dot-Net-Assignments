using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    enum WeekDays
    {
        Sun=3, Mon, Tue, Wed=10, Thu, Fri, Sat
    };

    class TestEnum
    {
        static void Main(string[] args)
        {
            var values = Enum.GetNames(typeof(WeekDays));

            foreach(var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine((int)WeekDays.Sun);
            Console.ReadKey();
        }
    }
}
