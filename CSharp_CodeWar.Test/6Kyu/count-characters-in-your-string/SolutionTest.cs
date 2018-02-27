using Xunit;
using CSharp_CodeWar.camelcase_method;

namespace CSharp_CodeWar.Test.camelcase_method
{
    public class SolutionTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal("TestCase", "test case".CamelCase());
            Assert.Equal("CamelCaseMethod", "camel case method".CamelCase());
            Assert.Equal("SayHello", "say hello".CamelCase());
            Assert.Equal("CamelCaseWord", " camel case word".CamelCase());
            Assert.Equal("GcphgkTpjkvjlexkaqzIccKvU", "gcphgk  tpjkvjlexkaqz icc kv u ".CamelCase());
            Assert.Equal("", "".CamelCase());
        }
    }
}
