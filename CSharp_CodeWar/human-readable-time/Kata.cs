using System;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/52685f7382004e774f0001f7/csharp
/// </summary>
namespace CSharp_CodeWar.human_readable_time
{
    /// <summary>
    /// http://www.codewars.com/kata/552c028c030765286c00007d/csharp
    /// </summary>
    public static class Kata
    {
        public static string GetReadableTime(int seconds)
        {
            #region Me
            int hour = seconds / 3600;
            int minute = (seconds - hour * 3600) / 60;
            int second = seconds % 60;

            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
            #endregion

            #region Best
            //return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
            #endregion
        }
    }
}
