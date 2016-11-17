namespace PrimeNumberSolution
{
    public class PrimeNumberCalculator : IPrimeCalculator
    {
        public int GetNthPrime(int nthNumber)
        {
            int currentPrime = 1;

            while (nthNumber > 0)
            {
                currentPrime = GetNextPrime(currentPrime);
                nthNumber--;
            }
            return currentPrime;
        }

        public int GetNextPrime(int primeNumber)
        {
            primeNumber++;

            while (!IsPrime(primeNumber))
                primeNumber++;

            return primeNumber;
        }

        public bool IsPrime(int numberToCheck)
        {
            if (NumberIsZeroOrOne(numberToCheck))
                return false;
            else
            {
                for (int divideByThis = 2; divideByThis <= numberToCheck / 2; divideByThis++)
                {
                    if (NumberCanBeDividedByAnotherNumber(numberToCheck, divideByThis))
                        return false;
                }
                return true;
            }
        }

        private bool NumberIsZeroOrOne(int number)
        {
            return number == 1 || number == 0;
        }

        private bool NumberCanBeDividedByAnotherNumber(int numberToCheck, int divideByThisNumber)
        {
            return numberToCheck % divideByThisNumber == 0;
        }
    }
}
