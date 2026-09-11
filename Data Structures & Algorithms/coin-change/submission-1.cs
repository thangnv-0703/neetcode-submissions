public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;
        for (int currentAmount = 0; currentAmount <= amount; currentAmount++)
        {
            foreach (var coin in coins)
            {
                if (currentAmount >= coin)
                {
                    dp[currentAmount] = Math.Min(dp[currentAmount], 1 + dp[currentAmount - coin]);
                }
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
