using System;

namespace PrimeCalculator
{
    public class Program
    {
        public static bool isPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return false;


            //if it's a non-prime number, it will certainly have a multiplier smaller than its square root. so we can just check that.

            int cutOff = (int)Math.Sqrt(number);

            for (int i = 3; i < cutOff; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(1004));
        }
    }
}
