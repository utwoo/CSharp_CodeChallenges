using CSharp_CodeWar.gap_in_primes;
using Xunit;

namespace CSharp_CodeWar.Test.gap_in_primes
{
    public class SolutionTest
    {
        [Fact]
        public static void test()
        {
            Assert.Equal(new long[] { 101, 103 }, Kata.Gap(2, 100, 110));
            Assert.Equal(new long[] { 103, 107 }, Kata.Gap(4, 100, 110));
            Assert.Null(Kata.Gap(6, 100, 110));
            Assert.Equal(new long[] { 359, 367 }, Kata.Gap(8, 300, 400));
            Assert.Equal(new long[] { 337, 347 }, Kata.Gap(10, 300, 400));
        }
    }
}
