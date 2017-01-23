using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class Car : Vehicle
    {
        string color;
        bool hasPowerSteering;
        bool hasPowerWindows;
        int capacity;

        //constant
        const float maxSpeed = 200.0f;

        //Overriden methods
        public override void accelerate()
        {
            if(speed + 20.0f < maxSpeed)
            {
                speed += 20.0f;
            }

            else
            {
                speed += (maxSpeed - speed);
            }
        }

        public override void decelerate()
        {
            if (speed - 20.0f > 0)
            {
                speed -= 20.0f;
            }
            else
            {
                speed = 0.0f;
            }
        }
    }
}
