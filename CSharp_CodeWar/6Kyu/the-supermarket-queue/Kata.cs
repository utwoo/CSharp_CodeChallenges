using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp
/// </summary>
namespace CSharp_CodeWar.the_supermarket_queue
{
    public class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] checkout = new int[n];

            customers.ToList().ForEach(v =>
            {
                Array.Sort(checkout);
                checkout[0] += v;
            });

            return checkout.Max();
        }
    }
}
