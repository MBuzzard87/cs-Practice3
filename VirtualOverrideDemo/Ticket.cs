using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Ticket : IEquatable<Ticket>
    {

        public int DurationInHours { get; set; }

        public Ticket(int duration)
        {
            DurationInHours = duration;
        }

        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }

    }
}
