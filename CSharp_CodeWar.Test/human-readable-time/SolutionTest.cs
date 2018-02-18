using Xunit;
using CSharp_CodeWar.human_readable_time;

namespace CSharp_CodeWar.Test.human_readable_time
{
    public class SolutionTest
    {
        [Fact]
        public void HumanReadableTest()
        {
            Assert.Equal("00:00:00", Kata.GetReadableTime(0));
            Assert.Equal("00:00:05", Kata.GetReadableTime(5));
            Assert.Equal("00:01:00", Kata.GetReadableTime(60));
            Assert.Equal("23:59:59", Kata.GetReadableTime(86399));
            Assert.Equal("99:59:59", Kata.GetReadableTime(359999));
        }
    }
}
