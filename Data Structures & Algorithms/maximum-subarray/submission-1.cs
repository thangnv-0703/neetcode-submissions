public class Solution {
    public int MaxSubArray(int[] nums) {
        var curSum = nums[0];
        var maxSum = nums[0];
        for (var i=1; i<nums.Length; i++)
        {
            if (curSum + nums[i] > nums[i])
            {
                curSum += nums[i];
            }
            else 
            {
                curSum = nums[i];
            }
            maxSum = Math.Max(curSum, maxSum);
        }
        return maxSum;
    }
}
