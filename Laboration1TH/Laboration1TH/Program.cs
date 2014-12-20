using System;

namespace Laboration1TH
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double totalKostnad = 0;
            int erhalletBelopp = 0;
            double attBetala = 0;
            double oresavrundning = 0;
            double tillbaka = 0;
            string inmatatTal;


            while (true)
            {
                try
                {
                    Console.Write("Ange summa att betala: ");
                    inmatatTal = Console.ReadLine();
                    totalKostnad = double.Parse(inmatatTal);
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }         
            
           
            
            Console.Write("Ange erhållet belopp: ");
            inmatatTal = Console.ReadLine();
            erhalletBelopp = int.Parse(inmatatTal);

        


            //Öresavrunding 
            attBetala = (uint)Math.Round(totalKostnad);
            oresavrundning = attBetala - totalKostnad;
            
            tillbaka = erhalletBelopp - attBetala;



            Console.WriteLine("\nKVITTO\n-----------------------------");

            Console.WriteLine("Totalt :   {0,20:c}\nÖresavrunding :{1,15:c}\nAtt betala :    {2,15:c}\nKontant       : {3,15:c}\nTillbaka :    {4,15:c}",
                totalKostnad,
                oresavrundning,
                attBetala,
                erhalletBelopp,
                tillbaka);
            Console.WriteLine("-----------------------------");

            
            


            if (tillbaka > 500 )
            {
                Console.WriteLine("500-lapp");
            }
        }        
    }
}
