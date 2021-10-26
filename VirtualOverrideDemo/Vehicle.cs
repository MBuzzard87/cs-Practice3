using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Vehicle
    {
        public string Color { get; set; }
        public int TopSpeed { get; set; }


        public Vehicle()
        {
            Color = "red";
            TopSpeed = 120;
        }

        public Vehicle(string color, int topSpeed)
        {
            Color = color;
            TopSpeed = topSpeed;
        }
    }
}
