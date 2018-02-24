using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CodeWar.primes_in_numbers
{
    /// <summary>
    /// https://www.codewars.com/kata/primes-in-numbers/csharp
    /// </summary>
    public static class Kata
    {
        private static Dictionary<long, List<int>> dicPrimeNumbers = new Dictionary<long, List<int>>()
        {
            { 2, new List<int>{ 2 } },
            { 3, new List<int>{ 3 } }
        };

        public static String factors(int lst)
        {
            string result = string.Empty;

            List<int> primes = primeNumbers(lst);
            foreach (var group in primes.GroupBy(v => v))
            {
                if (group.Count() == 1)
                    result += string.Format("({0})", group.Key);
                else
                    result += string.Format("({0}**{1})", group.Key, group.Count());
            }

            return result;
        }

        private static List<int> primeNumbers(long value)
        {
            if (value <= 1) return null;
            if (dicPrimeNumbers.ContainsKey(value)) return dicPrimeNumbers[value];

            var result = new List<int>();
            for (long i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    result.AddRange(primeNumbers(i));
                    result.AddRange(primeNumbers(value / i));

                    dicPrimeNumbers.Add(value, result);

                    return result;
                }
            }

            result = new List<int> { Convert.ToInt32(value) };
            dicPrimeNumbers.Add(value, result);

            return result;
        }

        #region Best
        //public static String factors(int lst)
        //{
        //    var primes = new List<string>();
        //    for (var number = 2; number <= lst; number++)
        //    {
        //        var count = 0;
        //        while (lst % number == 0) { count++; lst /= number; }
        //        if (count == 0) continue;
        //        primes.Add(String.Format(count > 1 ? "({0}**{1})" : "({0})", number, count));
        //    }
        //    return String.Join("", primes);
        //}
        #endregion
    }
}
