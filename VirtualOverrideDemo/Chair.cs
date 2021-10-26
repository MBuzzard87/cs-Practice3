using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Chair : Furniture
    {

        public Chair(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
