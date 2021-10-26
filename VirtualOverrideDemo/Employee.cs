using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Employee
    {

        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, int salary) {
            FirstName = firstName;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause() 
        {
            Console.WriteLine("I'm taking a break");
            
        }

    }
}
