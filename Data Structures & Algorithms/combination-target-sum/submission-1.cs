public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>> ();
        var combination = new Stack<int> ();
        Backtrack(nums, target, 0, combination, result);
        return result;
    }

    public void Backtrack(int[] nums, int target, int startIndex, Stack<int> combination, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(combination.ToList());
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (var i = startIndex; i < nums.Length; i++)
        {
            combination.Push(nums[i]);
            Backtrack(nums, target - nums[i], i, combination, result);
            combination.Pop();
        }
    }
}
