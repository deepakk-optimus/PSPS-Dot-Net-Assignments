using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Bicycle : Vehicle
    {
        public Bicycle(string _make, int _yearOfManufacture, string _model, float _speed) : base(_make, _yearOfManufacture, _model, _speed)
        {
        }

        public int GetCost()
        {
            return 1000;
        }
    }
}
