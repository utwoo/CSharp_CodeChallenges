using System;
using System.Linq;

namespace CSharp_CodeWar.build_tower
{
    /// <summary>
    /// https://www.codewars.com/kata/576757b1df89ecf5bd00073b/csharp
    /// </summary>
    public static class Kata
    {
        #region Me
        public static string[] TowerBuilder(int nFloors)
        {
            int count = 1 + (nFloors - 1) * 2;
            var result = Enumerable.Range(1, nFloors).Select(i =>
            {
                return string.Format("{0}{1}{0}",
                    string.Join("", Enumerable.Repeat(" ", (count - ((i - 1) * 2 + 1)) / 2).ToArray()),
                    string.Join("", Enumerable.Repeat("*", ((i - 1) * 2 + 1)).ToArray()));
            }).ToArray();

            return result;
        }
        #endregion

        #region Clever
        //return Enumerable.Range(1, nFloors).Select(i => string.Format("{0}{1}{0}", i == nFloors? "" : new string (' ', nFloors - i), new string ('*', 2 * i - 1))).ToArray();
        #endregion
    }
}
