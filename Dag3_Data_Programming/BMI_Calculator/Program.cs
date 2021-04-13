using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hoe kun je zelf je BMI berekenen?
            Je kunt je BMI zelf uitrekenen door je gewicht in kilo’s te delen door het kwadraat 
            van je lichaamslengte in meters.Als je bijvoorbeeld 65 kilo weegt en je bent 1,70 
            meter lang, dan bereken je je BMI als volgt: 65 kilo / (1, 70 x 1,70 meter) = 22,5.
            */

            //Oefening 3.3 BMI Calculator
            Console.WriteLine("3.3 BMI Calculator\n");

            Console.WriteLine("\nPlease give your length [m];");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease give your weight [kg];");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(length, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYour BMI =  {bmi}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
