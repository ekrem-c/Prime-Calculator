using System;

namespace PrimeCalculator
{
    public class Program
    {
        public static bool isPrime(int number)
        {
            if (number < 2) return false;

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(5));
        }
    }
}
