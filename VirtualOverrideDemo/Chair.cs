using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Chair : Furniture, IDestructable
    {

        public Chair(string color, string material)
        {
            Color = color;
            Material = material;
            DestructionSound = "DestroyedChair.mp3";
        }

        public string DestructionSound { get; set; }

        public void Destroy()
        {
            Console.WriteLine("The {0} {1} chair was destroyed. {2}", Color, Material, DestructionSound);
        }
    }
}
