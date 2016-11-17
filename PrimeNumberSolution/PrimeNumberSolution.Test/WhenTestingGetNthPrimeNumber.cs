using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberSolution.Test
{
    [TestClass]
    public class WhenTestingGetNthPrimeNumber
    {
        [TestMethod]
        public void GivenIAskForThe3rdPrimeNumberItShouldReturn5()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.GetNthPrime(3);

            Assert.AreEqual(5, result);
            
        }

        [TestMethod]
        public void GivenIAskForThe17thPrimeNumberItShouldReturn59()
        {
            var primeCalculator = new PrimeNumberCalculator();

            var result = primeCalculator.GetNthPrime(17);

            Assert.AreEqual(59, result);

        }
    }
}
