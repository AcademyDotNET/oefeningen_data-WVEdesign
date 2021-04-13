using System;

namespace OrakelVanDelphi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 3.6 Orakeltje van Delphi
            Console.WriteLine("3.6 Orakeltje van Delphi\n");

            Random randomGenerator = new Random();
            int funeralTime = randomGenerator.Next(5,125); //getallen tussen de 5 en 125 jaar

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nCongratulations!,  You have still {funeralTime} years to live, enjoy !\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
