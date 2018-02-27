using System.Linq;

namespace CSharp_CodeWar.find_the_odd_int
{
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            return seq.ToArray().GroupBy(v => v).First(group => group.Count() % 2 == 1).Key;
        }
    }
}
