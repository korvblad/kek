using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempelmedmattias
{
    public abstract class Vehicle
    {
        public double MaxSpeed { get; set; }

        public abstract void StartEngine()
        {
            Console.WriteLine("Startar motorn");
        }
        
        public abstract void StopEngine()
        {
            Console.WriteLine("Stoppar motorn");
        }

        public abstract void Drive()
        {
            Console.WriteLine("Kör omkring");
        }

    }
}
