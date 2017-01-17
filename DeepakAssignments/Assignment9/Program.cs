using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Maruti",2015,"Swift",200);
            car.Accerlate();
            car.Stop();
            Console.WriteLine(car.isMoving());
            Console.ReadKey();
        }
    }
}
