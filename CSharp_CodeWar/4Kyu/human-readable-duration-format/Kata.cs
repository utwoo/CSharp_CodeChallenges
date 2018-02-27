using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/52742f58faf5485cae000b9a/csharp
/// </summary>
namespace CSharp_CodeWar.human_readable_duration_format
{
    public class Kata
    {
        public static string formatDuration(int totalseconds)
        {
            List<string> formatParams = new List<string>();

            string[] formats = new string[]
            {
                "now",
                "{0}",
                "{0} and {1}",
                "{0}, {1} and {2}",
                "{0}, {1}, {2} and {3}",
                "{0}, {1}, {2}, {3} and {4}"
            };
            int years = totalseconds / (365 * 60 * 60 * 24);
            if (years != 0) formatParams.Add(string.Format("{0} {1}", years.ToString(), years == 1 ? "year" : "years"));

            int days = totalseconds / (60 * 60 * 24) % 365;
            if (days != 0) formatParams.Add(string.Format("{0} {1}", days.ToString(), days == 1 ? "day" : "days"));

            int hours = (totalseconds / (60 * 60)) % 24;
            if (hours != 0) formatParams.Add(string.Format("{0} {1}", hours.ToString(), hours == 1 ? "hour" : "hours"));

            int minutes = (totalseconds / 60) % 60;
            if (minutes != 0) formatParams.Add(string.Format("{0} {1}", minutes.ToString(), minutes == 1 ? "minute" : "minutes"));

            int seconds = totalseconds % 60;
            if (seconds != 0) formatParams.Add(string.Format("{0} {1}", seconds.ToString(), seconds == 1 ? "second" : "seconds"));

            return string.Format(formats[formatParams.Count], formatParams.ToArray());

            #region Clever
            //var t = TimeSpan.FromSeconds(totalseconds);
            //Func<int, string, string> f = (n, l) => n == 0 ? "" : $"{n} {l}" + (n == 1 ? "" : "s");
            //var h = new[] { f(t.Days / 365, "year"), f(t.Days % 365, "day"), f(t.Hours, "hour"), f(t.Minutes, "minute"), f(t.Seconds, "second") }.Where(p => p.Any());
            //return h.Count() == 0 ? "now" : h.Count() == 1 ? h.Single() : string.Join(", ", h.Take(h.Count() - 1)) + " and " + h.Last();
            #endregion
        }
    }
}
