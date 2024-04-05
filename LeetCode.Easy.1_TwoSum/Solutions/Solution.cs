using System.Collections.Generic;

namespace LeetCode.Easy._1_TwoSum.Solutions;

public class Solution
{
    /*
    1. 第一個迴圈，表示依序拿取每個位置的數值
    2. 第二個迴圈，根據前一個迴圈拿到的數值，往後依序查詢，找到相加為 target 的數值
    3. 如果找不到，使用第一個迴圈的下一個數值，重複執行上述動作，直到最後或是找到
    */
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

    /*
    1. 第一個迴圈，表示依序拿取每個位置的數值
    2. 從 Dictionary 找看看是否有數值符合相加為 target 的內容
    2.1 沒有 -> 把現有的數值和索引位置，當作 KeyValue Pair，存到 Dictionary 內
    2.2 有   -> 返回索引
    */
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