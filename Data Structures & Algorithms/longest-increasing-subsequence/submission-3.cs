public class Solution {
    public int LengthOfLIS(int[] nums) {
        var n = nums.Length;
        var dp = new int [n];
        Array.Fill(dp, 1);
        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[j] + 1, dp[i]);
                }
            }
        }
        return dp.Max();
    }
}
