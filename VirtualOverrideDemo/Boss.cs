using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Boss : Employee
    {

        private bool companyCar;

        public Boss(string firstName, int salary)
        {
            FirstName = firstName;
            Salary = salary;
            companyCar = true;
        }


    }
}
