using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {

        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name,age)
        {
            IsHappy = true;
        }

        //Override virtual Eat method within the Animal class
        public override void Eat()
        {

            // To call the Eat method from the base class (Animal) we use the keyword "base"
            base.Eat();
        }


        public override void MakeSound()
        {
            Console.WriteLine("Woof!!!");
        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }

    }
}
