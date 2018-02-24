using CSharp_CodeWar.primes_in_numbers;
using Xunit;

namespace CSharp_CodeWar.Test.primes_in_numbers
{
    public class SolutionTest
    {
        [Fact]
        public void Test1()
        {
            int lst = 7775460;
            Assert.Equal("(2**2)(3**3)(5)(7)(11**2)(17)", Kata.factors(lst));
        }
    }
}
