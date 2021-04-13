using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pi: {0} \ne: {1}", Math.PI, Math.E); // using Math constants
            //Oefening 3.2 Data - Geometric-fun
            Console.WriteLine("3.2 Data - Geometric-fun\n");

            Console.WriteLine("\nPlease give an angle in degrees[0-360]; ");
            double valueDegree = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            double valueRad = Math.PI * valueDegree / 180;
            Console.WriteLine($"\nan angle of {valueDegree}° = {valueRad} Radians\n");

            double valueSin = Math.Sin(valueRad);
            Console.WriteLine($"\nthe sine of this value = {valueSin} Radians\n");

            double valueCos = Math.Cos(valueRad);
            Console.WriteLine($"\nthe cosine of this value = {valueCos} Radians\n");

            double valueTan = Math.Tan(valueRad);
            Console.WriteLine($"\nthe tangent of this value = {valueTan} Radians\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
