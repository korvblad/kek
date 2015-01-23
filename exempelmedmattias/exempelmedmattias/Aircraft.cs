using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public abstract class Aircraft : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Jag flyger!");
        }
    }
}
