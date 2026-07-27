public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (hashMap.ContainsKey(complement))
            {
                return new [] { hashMap[complement], i };
            }
            else 
            {
                hashMap[nums[i]] = i;
            }
        }
        return new [] { -1, -1};
    }
}
