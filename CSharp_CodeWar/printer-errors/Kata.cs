using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/56541980fa08ab47a0000040/train/csharp
/// </summary>
namespace CSharp_CodeWar.printer_errors
{
    public class Kata
    {
        public static string PrinterError(String s)
        {
            return string.Format("{0}/{1}", s.ToCharArray().ToList().Where(c => c > 'm').Count(), s.Length);
        }
    }
}
