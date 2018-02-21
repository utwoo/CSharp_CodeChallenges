using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/58f5c63f1e26ecda7e000029/csharp
/// </summary>
namespace CSharp_CodeWar.mexican_wave
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            return str.Select((c, i) =>
            {
                return string.Format("{0}{1}{2}", str.Substring(0, i), Char.ToUpper(c), str.Substring(i + 1));
            })
            .Where(v => !v.Equals(str))
            .ToList();
        }
    }
}
