public class Solution {
    public int CountSubstrings(string s) {
        var n = s.Length;
        if (n <= 1)
        {
            return n;
        }
        bool [,] dp = new bool [n,n];
        int count = 0;
        for (var i = 0; i < n; i++)
        {
            dp[i, i] = true;
            count++;
        }
        for (var i = 0; i < n-1; i++)
        {
            if (s[i] == s[i+1])
            {
                dp[i, i+1] = true;
                count++;
            }
        }
        for (var subStrLen = 3; subStrLen <= n; subStrLen++)
        {
            for (var i = 0; i <= n - subStrLen; i++)
            {
                var j = i + subStrLen - 1;
                if (s[i] == s[j] && dp[i+1, j-1])
                {
                    count++;
                    dp[i,j] = true;
                }
            }
        }
        return count;
    }
}
