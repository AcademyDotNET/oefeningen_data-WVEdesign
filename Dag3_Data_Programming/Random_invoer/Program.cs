using System;

namespace Random_invoer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 3.7 Random_invoer op basis van voorgaande oefening.
            Console.WriteLine("3.7 Random integration with BMI-app \n");

            Console.WriteLine("\nPlease give your length [m];");
            double length = Convert.ToDouble(Console.ReadLine());

            Random randomGenerator = new Random();
            double weight = randomGenerator.Next(40, 130); //40<->130kg
            Console.WriteLine($"\nThankYou, luckily you don\'t have to give you\'re weight, \"Het Orakeltje van Delphi\" orakelt that you weigh {weight} kg.");

            double bmi = weight / Math.Pow(length, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYour BMI =  {bmi}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
