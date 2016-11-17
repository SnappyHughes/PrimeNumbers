using PrimeNumberSolution;
using System;

namespace PrimeCalculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeCalculator = new PrimeNumberCalculator();

            Console.WriteLine("Please Enter A Number: ");
            var input = Console.ReadLine();

            var number = int.Parse(input);

            Console.Write("The Nth Prime Number Is: " + primeCalculator.GetNthPrime(number));
            Console.ReadLine();
        }
    }
}
