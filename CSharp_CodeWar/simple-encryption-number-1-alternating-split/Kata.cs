using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/simple-encryption-number-1-alternating-split
/// </summary>
namespace CSharp_CodeWar.simple_encryption_number_1_alternating_split
{
    public class Kata
    {
        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n <= 0) return text;

            while (n-- > 0)
            {
                text = string.Concat(text.Where((c, i) => (i % 2 == 1)).Concat(text.Where((c, i) => (i % 2 == 0))));
            }

            return text;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrEmpty(encryptedText) || n <= 0) return encryptedText;

            while (n-- > 0)
            {
                string leftpart = string.Concat(encryptedText.Take(encryptedText.Length / 2));
                string rightpart = string.Concat(encryptedText.Skip(encryptedText.Length / 2));

                encryptedText = string.Concat(Enumerable.Range(0, encryptedText.Length).Select(i => i % 2 == 0 ? rightpart[i / 2] : leftpart[i / 2]));
            }
            return encryptedText;
        }
    }
}
