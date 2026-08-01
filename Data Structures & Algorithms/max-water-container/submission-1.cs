public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int maxWater = 0;
        while (left < right)
        {
            int currentWater = (right - left) * Math.Min(heights[left], heights[right]);
            maxWater = Math.Max(maxWater, currentWater);
            if (heights[left] < heights[right])
            {
                left += 1;
            }
            else if (heights[left] > heights[right])
            {
                right -= 1;
            }
            else {
                left += 1;
                right -= 1;
            }
        }
        return maxWater;
    }
}
