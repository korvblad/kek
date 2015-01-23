using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public class Bus : LandVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Kör buss");
        }
    }
}
