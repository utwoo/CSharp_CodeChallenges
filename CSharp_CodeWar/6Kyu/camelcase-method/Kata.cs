using System;
using System.Globalization;

namespace CSharp_CodeWar.camelcase_method
{
    /// <summary>
    /// https://www.codewars.com/kata/camelcase-method/csharp
    /// </summary>
    public static class Kata
    {
        public static string CamelCase(this string str)
        {
            #region Me
            if (string.IsNullOrEmpty(str)) return string.Empty;

            string[] arrStr = str.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] result = new string[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
                result[i] = arrStr[i].Substring(0, 1).ToUpper() + (arrStr[i].Length > 0 ? arrStr[i].Substring(1, arrStr[i].Length - 1) : string.Empty);

            return string.Join(string.Empty, result);
            #endregion

            #region Best
            //TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            //str = cultInfo.ToTitleCase(str);
            //str = str.Replace(" ", "");
            //return str;
            #endregion
        }
    }
}
