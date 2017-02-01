namespace Primes
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("SumOfDigitsForPrimes.txt"))
            {
                for (int i = 2; i < 1000000; i++)
                {
                    if (PrimesProperties.IsIntegerPrime(i))
                    {
                        if (PrimesProperties.GetSumOfDigitsForNumber(i) == 2)
                            sw.WriteLine(" ");
                        sw.Write(PrimesProperties.GetSumOfDigitsForNumber(i) + " ");
                    }
                }
            }
        }
    }
}
