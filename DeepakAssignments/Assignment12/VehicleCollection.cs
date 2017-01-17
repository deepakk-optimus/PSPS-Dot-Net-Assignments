using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class VehicleCollection : IEnumerable
    {
        Vehicle[] _vehicle = null;
        int index = 0;

        public VehicleCollection()
        {
            _vehicle = new Vehicle[10];
        }

        public void AddVehicle(Vehicle _vehicle)
        {
            this._vehicle[index] = _vehicle;
            index++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in _vehicle)
            {
                if (o == null)
                {
                    break;
                }
                yield return o;
            }
        }
    }
}
