using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog("Shia", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();

            Console.ReadKey();
        }
    }
}
