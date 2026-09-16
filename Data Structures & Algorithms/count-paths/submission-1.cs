public class Solution {
    public int UniquePaths(int m, int n) {
        int [,] dp = new int [m, n];
        for (var row = 0; row < m; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (row == 0 || col == 0)
                {
                    dp[row, col] = 1;
                } 
                else 
                {
                    dp[row, col] = dp[row - 1, col] + dp[row, col - 1];
                }
            }
        }
        return dp[m - 1, n - 1];
    }
}
