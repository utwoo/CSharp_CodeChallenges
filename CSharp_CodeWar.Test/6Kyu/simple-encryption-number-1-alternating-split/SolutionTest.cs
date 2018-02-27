using Xunit;
using CSharp_CodeWar.simple_encryption_number_1_alternating_split;

namespace CSharp_CodeWar.Test.simple_encryption_number_1_alternating_split
{
    public class SolutionTest
    {
        [Fact]
        public void EncryptExampleTests()
        {
            Assert.Equal("This is a test!", Kata.Encrypt("This is a test!", 0));
            Assert.Equal("hsi  etTi sats!", Kata.Encrypt("This is a test!", 1));
            Assert.Equal("s eT ashi tist!", Kata.Encrypt("This is a test!", 2));
            Assert.Equal(" Tah itse sits!", Kata.Encrypt("This is a test!", 3));
            Assert.Equal("This is a test!", Kata.Encrypt("This is a test!", 4));
            Assert.Equal("This is a test!", Kata.Encrypt("This is a test!", -1));
            Assert.Equal("hskt svr neetn!Ti aai eyitrsig", Kata.Encrypt("This kata is very interesting!", 1));
        }

        [Fact]
        public void DecryptExampleTests()
        {
            Assert.Equal("This is a test!", Kata.Decrypt("This is a test!", 0));
            Assert.Equal("This is a test!", Kata.Decrypt("hsi  etTi sats!", 1));
            Assert.Equal("This is a test!", Kata.Decrypt("s eT ashi tist!", 2));
            Assert.Equal("This is a test!", Kata.Decrypt(" Tah itse sits!", 3));
            Assert.Equal("This is a test!", Kata.Decrypt("This is a test!", 4));
            Assert.Equal("This is a test!", Kata.Decrypt("This is a test!", -1));
            Assert.Equal("This kata is very interesting!", Kata.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        [Fact]
        public void EmptyTests()
        {
            Assert.Equal("", Kata.Encrypt("", 0));
            Assert.Equal("", Kata.Decrypt("", 0));
        }

        [Fact]
        public void NullTests()
        {
            Assert.Null(Kata.Encrypt(null, 0));
            Assert.Null(Kata.Decrypt(null, 0));
        }
    }
}
