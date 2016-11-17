using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberSolution.Test
{
    [TestClass]
    public class WhenTestingIsPrime
    {
        [TestMethod]
        public void GivenNumberIsPrimeItShouldReturnTrue()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.IsPrime(3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenNumberIsNotPrimeItShouldReturnFalse()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.IsPrime(4);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenOneItShouldReturnFalse()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.IsPrime(1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GivenZeroItShouldReturnFalse()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.IsPrime(0);

            Assert.IsFalse(result);
        }
    }
}
