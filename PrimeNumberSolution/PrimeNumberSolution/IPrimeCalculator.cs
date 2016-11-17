namespace PrimeNumberSolution
{
    public interface IPrimeCalculator
    {
        int GetNextPrime(int intialNumber);
        int GetNthPrime(int nthNumber);
        bool IsPrime(int numberToCheck);
    }
}
