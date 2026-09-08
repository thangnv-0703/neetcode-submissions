public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        return Math.Max(Helper(nums[..^1]), Helper(nums[1..]));
    }

    public int Helper(int[] nums)
    {
        var n = nums.Length;
        if (n == 1)
        {
            return nums[0];
        }
        var curProfit = 0;
        var prevProfit = 0;
        foreach(var num in nums)
        {
            var profit = Math.Max(curProfit, prevProfit + num);
            prevProfit = curProfit;
            curProfit = profit;
        }
        return curProfit;
    }
}
