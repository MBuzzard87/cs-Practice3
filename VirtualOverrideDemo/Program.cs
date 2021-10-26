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
            /*
            Dog dog = new Dog("Shia", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
            */

            Post buzzPost = new Post("Thank you for visiting", "Buzz", true);
            Console.WriteLine(buzzPost.ToString());

            ImagePost buzzImagePost = new ImagePost("michaelbuzzard.com","Checkout my website", "Buzz", true);
            Console.WriteLine(buzzImagePost.ToString());

            Console.ReadKey();
        }
    }
}
