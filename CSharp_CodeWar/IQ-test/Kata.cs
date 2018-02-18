using System;
using System.Linq;

namespace CSharp_CodeWar.IQ_test
{
    /// <summary>
    /// http://www.codewars.com/kata/552c028c030765286c00007d/csharp
    /// </summary>
    public static class Kata
    {
        public static int Test(string numbers)
        {
            #region Me
            int index = 0;
            bool isEven = false;
            string[] arrNumbers = numbers.Split(" ".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);

            isEven = arrNumbers.Take(3).ToArray().Where(v => (Convert.ToInt32(v) % 2) == 0).Count() <= 1;

            index = isEven ?
                arrNumbers.ToList().IndexOf(arrNumbers.Where(v => (Convert.ToInt32(v) % 2) == 0).ToArray()[0]) :
                arrNumbers.ToList().IndexOf(arrNumbers.Where(v => (Convert.ToInt32(v) % 2) == 1).ToArray()[0]);

            return index + 1;
            #endregion

            #region Clever
            //var ints = numbers.Split(' ').Select(int.Parse).ToList();
            //var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
            //return ints.FindIndex(c => c == unique) + 1;
            #endregion

            #region Best
            //var nums = numbers.Split(' ').Select((s, i) => new { Value = int.Parse(s), Index = i });
            //var even = nums.Where(x => x.Value % 2 == 0);
            //var odd = nums.Where(x => x.Value % 2 == 1);
            //return even.Count() == 1 ? even.First().Index + 1 : odd.First().Index + 1;
            #endregion
        }
    }
}
