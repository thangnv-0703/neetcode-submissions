public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int> (nums);
        int longestChain = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (!numSet.Contains(nums[i] - 1))
            {
                int currentChain = 1;
                int currentNum = nums[i] + 1;
                while (numSet.Contains(currentNum))
                {
                    currentNum += 1;
                    currentChain += 1;
                }
                longestChain = Math.Max(longestChain, currentChain);
            }
        }
        return longestChain;
    }
}
