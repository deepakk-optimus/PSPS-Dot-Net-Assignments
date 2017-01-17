using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Vehicle : IComparable<Vehicle>
    {
        public string _make;
        public int _yearOfManufacture;
        public string _model;
        public float _speed;
        Boolean _isMoving = true;

        public Vehicle()
        {

        }
        public Vehicle(string _make, int _yearOfManufacture, string _model, float _speed)
        {
            this._make = _make;
            this._yearOfManufacture = _yearOfManufacture;
            this._model = _model;
            this._speed = _speed;
        }

        public void Accerlate()
        {
            _isMoving = true;
        }

        public void Deaccerlate()
        {
            _isMoving = true;
        }

        public void Stop()
        {
            _isMoving = false;
        }

        public Boolean isMoving()
        {
            return _isMoving;
        }

        public int CompareTo(Vehicle _otherVehicle)
        {
            if (this._speed > _otherVehicle._speed)
            {
                return 1;
            }
            else if (this._speed < _otherVehicle._speed)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(Object _object)
        {
            if (_object == null)
            {
                return false;
            }

            if(this.GetType() != _object.GetType())
            {
                return false;
            }
            Vehicle _vehicle = (Vehicle)_object;
            return (this._make == _vehicle._make) && (this._model == _vehicle._model) && (this._speed == _vehicle._speed) && (this._yearOfManufacture == _vehicle._yearOfManufacture);
        }
    }
}
