using System.Collections.Generic;
using System.Linq;

namespace CSharp_CodeWar.count_characters_in_your_string
{
    /// <summary>
    /// http://www.codewars.com/kata/52efefcbcdf57161d4000091/csharp
    /// </summary>
    public static class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            #region Me
            return str.GroupBy(c => c).ToDictionary(group => group.Key, group => group.Count());
            #endregion
        }
    }
}
