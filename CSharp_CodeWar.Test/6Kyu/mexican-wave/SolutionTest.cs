using Xunit;
using CSharp_CodeWar.mexican_wave;
using System.Collections.Generic;

namespace CSharp_CodeWar.Test.mexican_wave
{
    public class SolutionTest
    {
        [Fact]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.Equal(result, kata.wave("hello"));
        }

        [Fact]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.Equal(result, kata.wave("codewars"));
        }

        [Fact]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { };
            Assert.Equal(result, kata.wave(""));
        }

        [Fact]
        public void BasicTest4()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.Equal(result, kata.wave("two words"));
        }

        [Fact]
        public void BasicTest5()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.Equal(result, kata.wave(" gap "));
        }
    }
}
