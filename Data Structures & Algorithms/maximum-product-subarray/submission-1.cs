public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProduct = nums[0];
        int maxEndingHere = nums[0];
        int minEndingHere = nums[0];
        foreach (var num in nums[1..])
        {
            int prevMax = maxEndingHere;
            int prevMin = minEndingHere;
            maxEndingHere = new int[] {num, prevMax * num, prevMin * num}.Max();
            minEndingHere = new int[] {num, prevMax * num, prevMin * num}.Min();
            maxProduct = Math.Max(maxProduct, maxEndingHere);
        }
        return maxProduct;
    }
}
