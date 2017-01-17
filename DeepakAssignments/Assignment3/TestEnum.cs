using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TestEnum
    {
        enum WeekDays {Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Sun);
            Console.WriteLine(WeekDays.Mon);
            Console.WriteLine(WeekDays.Tue);
            Console.WriteLine(WeekDays.Wed);
            Console.WriteLine(WeekDays.Thu);
            Console.WriteLine(WeekDays.Fri);
            Console.WriteLine(WeekDays.Sat);
          
            Console.ReadKey();
        }
    }
}
