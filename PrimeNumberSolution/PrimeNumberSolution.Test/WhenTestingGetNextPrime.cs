using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberSolution.Test
{
    [TestClass]
    public class WhenTestingGetNextPrime
    {
        [TestMethod]
        public void ItShouldReturn7GivenIPassIn5()
        {
            var primeCalculator = new PrimeNumberCalculator();

            Assert.AreEqual(7, primeCalculator.GetNextPrime(5));
        }

        [TestMethod]
        public void ItShouldReturn13GivenIPassIn17()
        {
            var primeCalculator = new PrimeNumberCalculator();

            Assert.AreEqual(17, primeCalculator.GetNextPrime(13));
        }

        [TestMethod]
        public void ItShouldReturn83GivenIPassIn89()
        {
            var primeCalculator = new PrimeNumberCalculator();

            Assert.AreEqual(89, primeCalculator.GetNextPrime(83));
        }

        [TestMethod]
        public void ItShouldReturn157GivenIPassIn151()
        {
            var primeCalculator = new PrimeNumberCalculator();

            Assert.AreEqual(157, primeCalculator.GetNextPrime(151));
        }

        [TestMethod]
        public void ItShouldReturn3GivenIPassIn2()
        {
            var primeCalculator = new PrimeNumberCalculator();

            Assert.AreEqual(3, primeCalculator.GetNextPrime(2));
        }
    }
}
