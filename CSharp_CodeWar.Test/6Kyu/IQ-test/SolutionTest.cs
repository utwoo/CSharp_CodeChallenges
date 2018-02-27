using Xunit;
using CSharp_CodeWar.IQ_test;

namespace CSharp_CodeWar.Test.IQ_test
{
    public class SolutionTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Kata.Test("2 4 7 8 10"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, Kata.Test("1 2 2"));
        }
    }
}
