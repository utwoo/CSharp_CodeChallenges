using CSharp_CodeWar.steps_in_primes;
using Xunit;

namespace CSharp_CodeWar.Test.steps_in_primes
{
    public class SolutionTest
    {
        [Fact]
        public static void test1()
        {
            Assert.Equal(new long[] { 101, 103 }, Kata.Step(2, 100, 110));
            Assert.Equal(new long[] { 103, 107 }, Kata.Step(4, 100, 110));
            Assert.Equal(new long[] { 101, 107 }, Kata.Step(6, 100, 110));
            Assert.Equal(new long[] { 359, 367 }, Kata.Step(8, 300, 400));
            Assert.Equal(new long[] { 307, 317 }, Kata.Step(10, 300, 400));
        }
    }
}
