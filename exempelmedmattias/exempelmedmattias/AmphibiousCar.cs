using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public class AmphibiousCar : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("kör vattenbil");
        }
        public override void StartEngine()
        {
            Console.WriteLine("Starta vattenmotor - blubb blubb");
        }
    }
}
