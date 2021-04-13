using System;

namespace Op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 3.4 Op-de-poef
            Console.WriteLine("3.4 Op-de-poef\n");

            int n = 1;
            double poef = 0;

            while (n <= 5)
            {
                Console.WriteLine($"Voer bedrag van week {n} in:");
                poef += Convert.ToDouble(Console.ReadLine());
                n++;
            }

            double weeksToPay = poef / 10;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTotaal van de poef is EUR {poef}. En het zal {Math.Ceiling(weeksToPay)} weken duren om volledig afbetaald te worden aan 10EUR/week.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
