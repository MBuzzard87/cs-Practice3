using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Car : Vehicle
    {

        public Car(string color, int topSpeed)
        {
            Color = color;
            TopSpeed = topSpeed;
        }
    }
}
