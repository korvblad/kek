using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public class Truck : LandVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("vad pågår?");
        }
    }
}
