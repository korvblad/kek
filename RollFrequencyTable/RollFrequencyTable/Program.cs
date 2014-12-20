using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFrequencyTable
{

     /// <summary>
     ///  Applikationen simulerar tärningskast och presterar utfallert i en frekvenstabell.
     /// </summary>
    class Program
    {
        /// <summary>
        /// Startpunkt for applikationen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int antal = 0;
            int[] frekvenstabell = new int[6];





            antal = LasInAntalKast();
            frekvenstabell = KastaTarning(antal);

            VisaFrekvenstabell(frekvenstabell);

        }

        private static int LasInAntalKast()
        {
            int antal = 0;

            while(true)
            {
                try
                {
                    Console.Write("Ange antal tärningskast [100-1000]: ");
                    antal = int.Parse(Console.ReadLine());
                    
                    if(antal < 100 || antal > 1000)
                    {
                           throw new ApplicationException();
                    }
                    
                    return antal;

            } 
            catch
            {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nFEL! Ange ett heltal mellan 100 och 1000\n");
        Console.ResetColor();

}
}
}
        private static int[] KastaTarning(int antalKast)
        {
           int[] frekvenstabell = new int[6];
           Random tarning = new Random();

        for (int i = 0; i < antalKast; i++)
    {
        frekvenstabell[tarning.Next(0, 6)]++;
    }
            
        return frekvenstabell;

    }


        private static void VisaFrekvenstabell(int[] frekvenstabell)
        {
            string[] sidnamn = { "Ettor", "Tvåor", "Treor", "Fyror", "Femmor", "Sexor" };

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------");
            Console.WriteLine("Frekvenstabell");
            Console.WriteLine("--------------");
            Console.ResetColor();

            for (int i = 0; i < sidnamn.Length; i++)
            {
                Console.WriteLine("{0,-7}: {1,4}", sidnamn[i], frekvenstabell[i]);
                Console.WriteLine("------------");
            }


        }

    }
}
