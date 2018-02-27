using CSharp_CodeWar.consecutive_k_primes;
using Xunit;

namespace CSharp_CodeWar.Test.consecutive_k_primes
{
    public class SolutionTest
    {
        private static void testing(int k, long[] arr, int expected)
        {
            Assert.Equal(expected, Kata.ConsecKprimes(k, arr));
        }

        [Fact]
        public static void test1()
        {
            testing(6, new long[] { 10098 }, 0);
            testing(6, new long[] { 10176, 10164 }, 0);
            testing(5, new long[] { 10116, 10108, 10092, 10104, 10100, 10096, 10088 }, 6);
            testing(5, new long[] { 10188, 10192, 10212, 10184, 10200, 10208 }, 1);
            testing(4, new long[] { 10175, 10185, 10180, 10197 }, 3);
        }
    }
}
