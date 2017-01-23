using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Induction
{
    class Bus : Vehicle
    {
        int capacity;
        bool isAirConditioned;
        bool hasAutoTransmission;

        //constant
        const float maxSpeed = 120.0f;

        //Overriden methods
        public override void accelerate()
        {
            if (speed + 5.0f < maxSpeed)
            {
                speed += 5.0f;
            }

            else
            {
                speed += (maxSpeed - speed);
            }
        }

        public override void decelerate()
        {
            if (speed - 5.0f > 0.0f)
            {
                speed -= 5.0f;
            }

            else
            {
                speed = 0.0f;
            }
        }

    }
}
