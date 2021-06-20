using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//prime calculator: https://www.calculatorsoup.com/calculators/math/prime-number-calculator.php



namespace PrimeCalculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void isPrimeCanaryTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void isPrimeInitialTest()
        {
            Assert.IsFalse(Program.isPrime(1));
        }

        [TestMethod()]
        public void isPrimeNegativeValueTest()
        {
            int negative = -31;

            Assert.IsFalse(Program.isPrime(negative));
        }

        [TestMethod()]
        public void isPrimeBigNonPrimeTest()
        {
            int nonPrime = 75;

            Assert.IsFalse(Program.isPrime(nonPrime));
        }

        [TestMethod()]
        public void isPrimeFirst100PrimesTest()
        {
            List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            foreach (int number in primeNumbers)
            {
                Assert.IsTrue(Program.isPrime(number));
            }

        }

        [TestMethod()]
        public void isPrimeBigNumberPrimeTest()
        {
            int bigNumber = Int32.MaxValue;

            Assert.IsTrue(Program.isPrime(bigNumber));
        }

        public void isPrimeBigNumNonPrimeTest()
        {
            List<int> bigNonPrimes = new List<int> { 1000, 1002, 1004, 1006, 1008, 1010, 1012, 1014, 1016, 1018, 1020, 1024, 1026, 1028 };
            foreach (int bigNum in bigNonPrimes)
            {
                Assert.IsFalse(Program.isPrime(bigNum));
            }
        }
    }
}