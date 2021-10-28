using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    interface IDestructable
    {

        string DestructionSound { get; set; }

        void Destroy();

    }
}
