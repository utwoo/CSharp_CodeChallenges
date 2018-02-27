using Xunit;
using CSharp_CodeWar.decode_the_Morse_code;

namespace CSharp_CodeWar.Test.decode_the_Morse_code
{
    public class SolutionTest
    {
        [Fact]
        public void MorseCodeDecoderBasicTest_1()
        {
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "HEY JUDE";

            string actual = Kata.Decode(input);

            Assert.Equal(expected, actual);
        }
    }
}
