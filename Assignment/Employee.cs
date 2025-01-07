using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is Working");
        }
    }

    internal class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is Managing");
        }
    }
}
