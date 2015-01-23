using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exempelmedmattias
{
    public class Fighter : Aircraft
    {
        public override void StartEngine()
        {
            Console.WriteLine("Startar motorn - FRISROSROOOCSOOOVOOOOSHH...");
        }
    }
}
