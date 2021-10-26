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

        public void Learn() { }

        public override void Work() { }

    }
}
