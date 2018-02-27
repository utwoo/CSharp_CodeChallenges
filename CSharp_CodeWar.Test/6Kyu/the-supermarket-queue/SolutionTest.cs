using Xunit;
using CSharp_CodeWar.the_supermarket_queue;

namespace CSharp_CodeWar.Test.the_supermarket_queue
{
    public class SolutionTest
    {
        [Fact]
        public void ExampleTest1()
        {
            long expected = 0;

            long actual = Kata.QueueTime(new int[] { }, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleTest2()
        {
            long expected = 10;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleTest3()
        {
            long expected = 9;

            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleTest4()
        {
            long expected = 5;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.Equal(expected, actual);
        }
    }
}
