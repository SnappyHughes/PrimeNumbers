using PrimeNumberSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPrimeCalculator _primeCalculator;

        public HomeController()
        {
            _primeCalculator = new PrimeNumberCalculator();
        }

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(int number)
        {
            var primeNumber = _primeCalculator.GetNthPrime(number);

            return View("Index", primeNumber);
        }
    }
}