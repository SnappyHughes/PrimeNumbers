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
    }
}
