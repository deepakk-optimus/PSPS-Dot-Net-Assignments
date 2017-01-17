using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Car : Vehicle
    {
        public Car(string _make, int _yearOfManufacture, string _model, float _speed) : base(_make, _yearOfManufacture, _model, _speed)
        {
        }

        public string GetMileage()
        {
            return "200kmpl";
        }
    }
}
