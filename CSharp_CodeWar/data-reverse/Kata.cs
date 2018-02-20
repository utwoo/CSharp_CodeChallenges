using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CodeWar.data_reverse
{
    /// <summary>
    /// https://www.codewars.com/kata/569d488d61b812a0f7000015/csharp 
    /// </summary>
    public static class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            #region Me
            int length = data.Length;
            List<int> result = new List<int>();
            do
            {
                result.AddRange(data.Skip(length - 8).Take(8));
                length -= 8;
            } while (length > 0);

            return result.ToArray();
            #endregion

            #region Clever
            //int[] bits = data;

            //for (int i = 0; i < data.Length; i += 8)
            //    Array.Reverse(bits, i, 8);

            //Array.Reverse(bits);
            //return bits;
            #endregion
        }
    }
}
