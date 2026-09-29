public class Solution {
    public int MissingNumber(int[] nums) {
        var length = nums.Length;
        var res = length;
        for (var i = 0; i < length; i++)
        {
            res += (i - nums[i]);
        }
        return res;
    }
}
