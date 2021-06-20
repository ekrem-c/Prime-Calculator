using System;

//the link I used to verify prime numbers: https://www.calculatorsoup.com/calculators/math/prime-number-calculator.php

namespace PrimeCalculator
{
    public class Program
    {
        public static bool isPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;


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
