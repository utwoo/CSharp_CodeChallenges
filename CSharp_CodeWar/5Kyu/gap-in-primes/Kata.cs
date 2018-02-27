using System;

/// <summary>
/// http://www.codewars.com/kata/gap-in-primes
/// </summary>
namespace CSharp_CodeWar.gap_in_primes
{
    public class Kata
    {
        public static long[] Gap(int g, long m, long n)
        {
            for (long i = m; i <= n - g; i++)
            {
                if (isPrime(i) && isPrime(i + g) && !isPrimeRange(i + 2, i + g - 2))
                    return new long[2] { i, i + g };
            }

            return null;
        }

        private static bool isPrimeRange(long x, long y)
        {
            for (long i = x; i <= y; i++)
                if (isPrime(i)) return true;

            return false;
        }

        private static bool isPrime(long v)
        {
            if (v <= 3) return (v >= 2);
            if (v % 2 == 0) return false;

            for (long i = 3; i <= Math.Sqrt(v); i += 2)
                if (v % i == 0) return false;

            return true;
        }
    }
}
