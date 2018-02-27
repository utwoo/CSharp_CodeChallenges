using CSharp_CodeWar.count_characters_in_your_string;
using System.Collections.Generic;
using Xunit;

namespace CSharp_CodeWar.Test.count_characters_in_your_string
{
    public class SolutionTest
    {
        [Fact]
        public static void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.Equal(d, Kata.Count("aaaa"));
        }

        [Fact]
        public static void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.Equal(d, Kata.Count("aabb"));
        }
    }
}
