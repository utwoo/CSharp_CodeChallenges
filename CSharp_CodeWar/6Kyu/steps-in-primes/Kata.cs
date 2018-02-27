using System;

/// <summary>
/// https://www.codewars.com/kata/steps-in-primes
/// </summary>
namespace CSharp_CodeWar.steps_in_primes
{
    public class Kata
    {
        public static long[] Step(int g, long m, long n)
        {
            for (long i = m; i <= n - g; i++)
            {
                if (isPrime(i) && isPrime(i + g))
                    return new long[2] { i, i + g };
            }

            return null;
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
