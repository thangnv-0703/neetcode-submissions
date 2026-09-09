public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        if (n == 1)
        {
            return s[0].ToString();
        }
        int startIdx = 0; 
        int maxLength = 1;
        bool[,] dp = new bool[n, n];
        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i+1])
            {
                dp[i, i+1] = true;
                maxLength = 2;
                startIdx = i;
            }
        }
        for (int subStrLen = 3; subStrLen <= n; subStrLen++)
        {
            for (int i = 0; i <= n - subStrLen; i++)
            {
                int j = i + subStrLen - 1;
                if (dp[i + 1, j - 1] && s[i] == s[j])
                {
                    maxLength = subStrLen;
                    startIdx = i;
                    dp[i, j] = true;
                }
            }
        }
        return s.Substring(startIdx, maxLength);
    }
}
