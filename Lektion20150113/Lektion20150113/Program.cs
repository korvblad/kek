using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion20150113
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();


            for (int i = 0; i < 100; i++)
            {
                die.Throw();
                Console.WriteLine(die._faceValue);
            }


          



 
            
        }
    }
}
