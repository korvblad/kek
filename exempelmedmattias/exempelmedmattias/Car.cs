using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public class Car : LandVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Startar motorn - Ramm dabba dam, ramm dam, dam...");
        }
   
    }
}
