using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/problems/two-sum/
/// </summary>
namespace CSharp_LeetCode.P000
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }

                dic[nums[i]] = i;
            }
            return null;
        }
    }
}
