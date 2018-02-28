using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CodeWar.decode_the_Morse_code
{
    /// <summary>
    /// https://www.codewars.com/kata/decode-the-morse-code
    /// </summary>
    public static class Kata
    {
        private static Dictionary<string, char> dicMorse = new Dictionary<string, char>()
        {
            #region Morse
            {".-",      'A' },
            {"-...",    'B' },
            {"-.-.",    'C' },
            {"-..",     'D' },
            {".",       'E' },
            {"..-.",    'F' },
            {"--.",     'G' },
            {"....",    'H' },
            {"..",      'I' },
            {".---",    'J' },
            {"-.-",     'K' },
            {".-..",    'L' },
            {"--",      'M' },
            {"-.",      'N' },
            {"---",     'O' },
            {".--.",    'P' },
            {"--.-",    'Q' },
            {".-.",     'R' },
            {"...",     'S' },
            {"-",       'T' },
            {"..-",     'U' },
            {"...-",    'V' },
            {".--",     'W' },
            {"-..-",    'X' },
            {"-.--",    'Y' },
            {"--..",    'Z' },
            {"-----",   '0' },
            {".----",   '1' },
            {"..---",   '2' },
            {"...--",   '3' },
            {"....-",   '4' },
            {".....",   '5' },
            {"-....",   '6' },
            {"--...",   '7' },
            {"---..",   '8' },
            {"----.",   '9' },
            #endregion
        };

        public static string Decode(string morseCode)
        {
            return morseCode.Split("   ", StringSplitOptions.RemoveEmptyEntries).Select(word =>
            {
                return word.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(character => dicMorse[character])
                .Aggregate(string.Empty, (str1, str2) => str1 + str2);
            }).Aggregate(string.Empty, (str1, str2) => $"{str1 + " " + str2}").Trim();
        }
    }
}
