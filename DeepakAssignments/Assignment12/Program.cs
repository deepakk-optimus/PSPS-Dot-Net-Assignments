using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle _marutiCar = new Vehicle("Maruti",2015,"swift",500);
            Vehicle _audiCar = new Vehicle("Audi", 2017, "Q7", 100);
            Vehicle _mercedezCar = new Vehicle("Mercedez Benz", 2018, "Top", 2500);
            Vehicle _mercedezCar2 = new Vehicle("Mercedez Benz", 2018, "Top", 2500);

            List<Vehicle> _vehicleList = new List<Vehicle>();

            _vehicleList.Add(_marutiCar);
            _vehicleList.Add(_mercedezCar);
            _vehicleList.Add(_audiCar);
            _vehicleList.Sort();

            foreach(Vehicle v in _vehicleList)
            {
                Console.WriteLine("Car Name: {0}  Car speed {1}", v._make, v._speed);
            }
            Console.WriteLine(_marutiCar.Equals(_audiCar));
            Console.WriteLine(_mercedezCar.Equals(_mercedezCar2));

            VehicleCollection _vehicleCollection = new VehicleCollection();
            _vehicleCollection.AddVehicle(_marutiCar);
            _vehicleCollection.AddVehicle(_mercedezCar);
            _vehicleCollection.AddVehicle(_audiCar);

            foreach(Vehicle v in _vehicleCollection)
            {
                Console.WriteLine("Car Name: {0}  Car speed {1}", v._make, v._speed);
            }

            Console.ReadKey();
        }
    }
}
