using PrimeCalculator.Web.Helpers;
using PrimeNumberSolution;
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
        public ActionResult Index(int nthPrime)
        {
            if (nthPrime == 0)
            {
                ViewBag.Message = MessageHelper.InputIsInvalid;
                return View("Index");
            }
            
            var primeNumber = _primeCalculator.GetNthPrime(nthPrime);

            return View("Index", primeNumber);
        }
    }
}