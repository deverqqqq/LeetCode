using System.Collections.Generic;

namespace LeetCode.Easy._1_TwoSum.Solutions;

public class Solution
{
    public int[] TwoSum_BruteForce(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [0, 0];
    }

    public int[] TwoSum_Hash(int[] nums, int target)
    {
        var dc = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var hasValue = dc.TryGetValue(target - nums[i], out var index);
            if (hasValue)
            {
                return [i, index];
            }

            dc[nums[i]] = i;
        }

        return [0, 0];
    }
}