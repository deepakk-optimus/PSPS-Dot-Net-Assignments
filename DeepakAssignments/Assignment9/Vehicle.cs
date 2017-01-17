using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Vehicle
    {
        private string _make;
        private int _yearOfManufacture;
        private string _model;
        private float _speed;
        Boolean _isMoving = true;

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
    }
}
