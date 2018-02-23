using System;
using System.Collections.Generic;

namespace CSharp_CodeWar.k_primes
{
    /// <summary>
    /// https://www.codewars.com/kata/k-primes
    /// </summary>
    public static class Kata
    {
        private static Dictionary<long, int> dicPrimeCount = new Dictionary<long, int>() { { 2, 1 }, { 3, 1 } };

        public static long[] CountKprimes(int k, long start, long end)
        {
            List<long> listPrimes = new List<long>();
            for (long i = start; i <= end; i++)
            {
                if (primeCount(i) == k)
                    listPrimes.Add(i);
            }

            return listPrimes.ToArray();
        }
        public static int Puzzle(int s)
        {
            int result = 0;

            long[] primes1 = CountKprimes(1, 2, s);
            long[] primes3 = CountKprimes(3, 2, s);
            long[] primes7 = CountKprimes(7, 2, s);

            foreach (long prime1 in primes1)
                foreach (long prime3 in primes3)
                    foreach (long prime7 in primes7)
                    {
                        if (prime1 + prime3 + prime7 == s)
                            result++;
                    }

            return result;
        }

        private static int primeCount(long value)
        {
            if (value <= 1) return 0;
            if (dicPrimeCount.ContainsKey(value)) return dicPrimeCount[value];

            int result = 0;
            for (long i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    result = primeCount(i) + primeCount(value / i);
                    dicPrimeCount.Add(value, result);
                    return result;
                }
            }

            dicPrimeCount.Add(value, 1);
            return 1;
        }
    }
}
