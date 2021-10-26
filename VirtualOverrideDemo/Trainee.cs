using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Trainee : Employee
    {

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string firstName, int salary, int workingHours, int schoolHours) : base(firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }
        public void Learn() 
        {
            Console.WriteLine("I'm at school learning right now, I have {0} hours of school this week", SchoolHours);
        }

        public new void Work() 
        {
            Console.WriteLine("I'm at work but I'm not getting paid even thoguht I put in {0} hours", WorkingHours);
        }

    }
}
