using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}