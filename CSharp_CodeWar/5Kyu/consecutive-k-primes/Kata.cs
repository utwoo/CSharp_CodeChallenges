using System;
using System.Collections.Generic;

namespace CSharp_CodeWar.consecutive_k_primes
{
    /// <summary>
    /// http://www.codewars.com/kata/573182c405d14db0da00064e/csharp
    /// </summary>
    public static class Kata
    {
        private static Dictionary<long, int> dicPrimeCount = new Dictionary<long, int>() { { 2, 1 }, { 3, 1 } };

        public static int ConsecKprimes(int k, long[] arr)
        {
            if (arr.Length < 2) return 0;

            int result = 0;
            int preCount = -1, count = -1;

            foreach (long item in arr)
            {
                count = primeCount(item);
                result += (count == k && preCount == k) ? 1 : 0;
                preCount = count;
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
