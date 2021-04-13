using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 3.5 Feestkassa
            Console.WriteLine("3.5 feestkassa\n");

            double subTotaal = 0;

            Console.WriteLine("\nAantal verkochte porties frietjes+mosseltjes?");
            double frietjes = Convert.ToDouble(Console.ReadLine()) * 20;
            subTotaal += frietjes;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTussenprijs = EUR {frietjes}");
            Console.ForegroundColor = ConsoleColor.Gray;
             
            Console.WriteLine("\nAantal verkochte vol au vent?");
            double volAuVent = Convert.ToDouble(Console.ReadLine()) * 10;
            subTotaal += volAuVent;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTussenprijs = EUR {frietjes} + EUR {volAuVent}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nAantal verkochte ijsjes?");
            double ijsjes = Convert.ToDouble(Console.ReadLine()) * 3;
            subTotaal += ijsjes;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTussenprijs = EUR {frietjes} + EUR {volAuVent} + EUR {ijsjes}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nAantal verkochte dranken?");
            double dranken = Convert.ToDouble(Console.ReadLine()) * 2;
            subTotaal += dranken;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTussenprijs = EUR {frietjes} + EUR {volAuVent} + EUR {ijsjes} + EUR {dranken}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHet Totaal te betalen bedrag is EUR {subTotaal}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
