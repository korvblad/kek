using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private const string Anvandare = "Harry";
        private const string Losenord = "qwerty";

        static void Main(string[] args)
        {

            string anvandarnamn = "";
            string losenord = string.Empty;

            // mata in användarnamn
            Console.Write("Ange användarnamn; ");
            anvandarnamn = Console.ReadLine();
            // mata in lösenord
            Console.Write("Ange lösenord; ");
            losenord = Console.ReadLine();
            // bekräfta anv och lösen
            if(anvandarnamn == Anvandare && losenord == Losenord)
            {
                Console.WriteLine("Inloggad!");

            }

        
            else
            {
                Console.WriteLine("Felaktigt inloggning");
            }
            // skriv ut resultatet
        }
    }
}
