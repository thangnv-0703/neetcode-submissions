public class Solution {
    public bool CanJump(int[] nums) {
        var n = nums.Length;
        var goal = nums[n-1];
        for (var i=n-1; i>=0; i--)
        {
            if (nums[i] + i >= goal)
            {
                goal = i;
            }
        }
        return goal == 0;
    }
}
