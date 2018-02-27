using Xunit;
using CSharp_CodeWar.human_readable_duration_format;

namespace CSharp_CodeWar.Test.human_readable_duration_format
{
    public class SolutionTest
    {
        [Fact]
        public void test1()
        {
            Assert.Equal("now", Kata.formatDuration(0));
        }

        [Fact]
        public void test2()
        {
            Assert.Equal("1 second", Kata.formatDuration(1));
        }

        [Fact]
        public void test3()
        {
            Assert.Equal("1 minute and 2 seconds", Kata.formatDuration(62));
        }

        [Fact]
        public void test4()
        {
            Assert.Equal("2 minutes", Kata.formatDuration(120));
        }

        [Fact]
        public void test5()
        {
            Assert.Equal("1 hour, 1 minute and 2 seconds", Kata.formatDuration(3662));
        }
    }
}
