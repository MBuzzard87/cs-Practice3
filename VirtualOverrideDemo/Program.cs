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
            /* Animal - Dog
            Dog dog = new Dog("Shia", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
            */

            /* Post - ImagePost - VideoPost
            Post buzzPost = new Post("Thank you for visiting", "Buzz", true);
            Console.WriteLine(buzzPost.ToString());

            ImagePost buzzImagePost = new ImagePost("michaelbuzzard.com","Checkout my website", "Buzzington", true);
            Console.WriteLine(buzzImagePost.ToString());


            VideoPost buzzVideoPost = new VideoPost("Youtube.com", 10, "Checkout my movie", "Mike", true);
            Console.WriteLine(buzzVideoPost.ToString());

            buzzVideoPost.Play();
            */


            /*  Employee - Boss - Trainee
            Employee buzz = new Employee("Buzz", 70000);
            buzz.Work();
            buzz.Pause();

            Boss bruce = new Boss("Bruce Springsteen", 100000, "Kia Soul");
            bruce.Lead();
            bruce.Work();

            Trainee mike = new Trainee("Mike", 0, 40, 20);
            mike.Learn();
            mike.Work();
            mike.Pause();
           */

            /* Ticket
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            // will return true since the Equals method is changed within the ticket class
            Console.WriteLine(t2.Equals(t1));

            */
            /*
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Black", "Wood");

            Car damagedCar = new Car("Silver", 120);

            damagedCar.DestructablesNearby.Add(officeChair);
            damagedCar.DestructablesNearby.Add(gamingChair);

            damagedCar.Destroy();
            */

            IEnumerableDemo IEDemo = new IEnumerableDemo();
            

            Console.ReadKey();
        }
    }
}
