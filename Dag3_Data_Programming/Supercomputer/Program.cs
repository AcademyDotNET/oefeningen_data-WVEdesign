using System;

namespace Supercomputer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 3.1 Supercomputer
            Console.WriteLine("3.1 Data - Supercomputer\n");

            Console.WriteLine("\nPlease give first comma-separated value;");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nPlease give second comma-separated value;");
            decimal secNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nPlease give third comma-separated value;");
            decimal thirdNumber = Convert.ToDecimal(Console.ReadLine());

            decimal average = (firstNumber + secNumber + thirdNumber) / 3;

            Console.WriteLine($"\nAverage of {firstNumber}, {secNumber} en {thirdNumber} is {average}\n");
        }
    }
}
