public class Solution {
    public int NumDecodings(string s) {
        var n = s.Length;
        int [] dp = new int[n + 1];
        dp[0] = 1;
        for (var i = 1; i <= n; i++)
        {
            if (s[i - 1] != '0')
            {
                dp[i] = dp[i - 1];
            }
            if (i > 1 && s[i - 2] != '0')
            {
                var j = int.Parse(s.Substring(i - 2, 2));
                if (1 <= j && j <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
        }
        return dp[n];
    }
}
