using Xunit;
using CSharp_CodeWar.build_tower;

namespace CSharp_CodeWar.Test.build_tower
{
    public class SolutionTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(string.Join(",", new[] { "*" }), string.Join(",", Kata.TowerBuilder(1)));
            Assert.Equal(string.Join(",", new[] { " * ", "***" }), string.Join(",", Kata.TowerBuilder(2)));
            Assert.Equal(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Kata.TowerBuilder(3)));
        }
    }
}
