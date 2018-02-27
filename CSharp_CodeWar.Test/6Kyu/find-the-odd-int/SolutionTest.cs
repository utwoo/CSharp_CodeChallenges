using Xunit;
using CSharp_CodeWar.find_the_odd_int;

namespace CSharp_CodeWar.Test.find_the_odd_int
{
    public class SolutionTest
    {
        [Fact]
        public void Tests()
        {
            Assert.Equal(5, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
