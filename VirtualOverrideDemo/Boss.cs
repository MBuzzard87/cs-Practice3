using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Boss : Employee
    {

        public string CompanyCar { get; set; }

        public Boss(string firstName, int salary, string companyCar) :base(firstName, salary)
        {        
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm the boss, my name is {0}", FirstName);
        }


    }
}
