using CSharp_CodeWar.hamming_numbers;
using Xunit;

namespace CSharp_CodeWar.Test.hamming_numbers
{
    public class SolutionTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, Kata.hamming(1));
            Assert.Equal(2, Kata.hamming(2));
            Assert.Equal(3, Kata.hamming(3));
            Assert.Equal(4, Kata.hamming(4));
            Assert.Equal(5, Kata.hamming(5));
            Assert.Equal(6, Kata.hamming(6));
            Assert.Equal(8, Kata.hamming(7));
            Assert.Equal(9, Kata.hamming(8));
            Assert.Equal(10, Kata.hamming(9));
            Assert.Equal(12, Kata.hamming(10));
            Assert.Equal(15, Kata.hamming(11));
            Assert.Equal(16, Kata.hamming(12));
            Assert.Equal(18, Kata.hamming(13));
            Assert.Equal(20, Kata.hamming(14));
            Assert.Equal(24, Kata.hamming(15));
            Assert.Equal(25, Kata.hamming(16));
            Assert.Equal(27, Kata.hamming(17));
            Assert.Equal(30, Kata.hamming(18));
            Assert.Equal(32, Kata.hamming(19));
        }
    }
}
