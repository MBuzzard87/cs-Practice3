﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }


        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }

        public Furniture()
        {
            Color = "white";
            Material = "wood";
        }

    }
}
