using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CodeWar.data_reverse
{
    /// <summary>
    /// https://www.codewars.com/kata/decode-the-morse-code/csharp
    /// </summary>
    public static class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            int length = data.Length;
            List<int> result = new List<int>();
            do
            {
                result.AddRange(data.Skip(length - 8).Take(8));
                length -= 8;
            } while (length > 0);

            return result.ToArray();
        }
    }
}
