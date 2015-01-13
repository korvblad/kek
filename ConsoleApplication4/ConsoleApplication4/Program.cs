using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string disco = "Disco!";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Magenta ! ");
            }


        }

        public static object Now { get; set; }
    }
}
