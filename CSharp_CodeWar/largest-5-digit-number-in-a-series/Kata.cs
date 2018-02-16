using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/largest-5-digit-number-in-a-series/csharp
/// </summary>
namespace CSharp_CodeWar.largest_5_digit_number_in_a_series
{
    public class Kata
    {
        public static int GetNumber(string str)
        {
            #region My
            if (string.IsNullOrEmpty(str)) return 0;

            char maxNum = str.ToList().Max();
            int largest = 0;
            int index = str.IndexOf(maxNum);

            while (index != -1)
            {
                largest = Math.Max(largest, Convert.ToInt32(new String(str.Skip(index).Take(5).ToArray())));
                str = str.Substring(index + 1);
                index = str.IndexOf(maxNum);
            }

            return largest;

            #endregion

            #region Clever
            //return Enumerable.Range(0, str.Length - 4).Select(i => Convert.ToInt32(str.Substring(i, 5))).ToList().Max();
            #endregion
        }
    }
}
