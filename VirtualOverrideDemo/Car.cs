using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Car : Vehicle, IDestructable
    {

        public string DestructionSound { get; set; }

        
        public List<IDestructable> DestructablesNearby;


        public Car(string color, int topSpeed)
        {
            Color = color;
            TopSpeed = topSpeed;
            DestructionSound = "CarExplosion.mp3";
            DestructablesNearby = new List<IDestructable>();
        }


        public void Destroy()
        {
            Console.WriteLine("{0}, there's a fire", DestructionSound);
            foreach(IDestructable destructable in DestructablesNearby)
            {
                destructable.Destroy();
            }
        }
    }
}
