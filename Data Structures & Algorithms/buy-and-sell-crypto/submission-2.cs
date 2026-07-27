public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
            return 0;
        int maxProfit = 0;
        int minPrice = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
        }
        return maxProfit;
    }
}
