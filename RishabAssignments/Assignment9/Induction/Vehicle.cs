using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class Vehicle
    {
        public string make;
        public int yearOfManufacture;
        public string model;
        public float speed;

        public virtual void accelerate()
        {
            speed += 10.0f;
        }

        public virtual void decelerate()
        {
            if(speed - 10.0f > 0)
            {
                speed -= 10.0f;
            }

            else
            {
                speed = 0.0f;
            }
        }
        
        public bool isMoving()
        {
            bool result = false;
            if(speed > 0.0f)
            {
                result = true;
            }

            return result;
        }

        public void printVehicleState()
        {
            if(isMoving())
            {
                Console.WriteLine("Moving!");
            }

            else
            {
                Console.WriteLine("Its Stationary!");
            }
        }
    }
}
