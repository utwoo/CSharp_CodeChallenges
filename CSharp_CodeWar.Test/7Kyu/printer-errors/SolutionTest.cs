using Xunit;
using CSharp_CodeWar.printer_errors;

namespace CSharp_CodeWar.Test.printer_errors
{
    public class SolutionTest
    {
        [Fact]
        public static void test()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.Equal("3/56", Kata.PrinterError(s));
        }
    }
}
