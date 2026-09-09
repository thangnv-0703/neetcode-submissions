class Solution:
    def longestPalindrome(self, s: str) -> str:
        n = len(s)
        if n == 1:
            return s[0]
        # if n == 2:
        #     return n[0] == n[1]
        dp = [[False] * n for _ in range(n)]
        start_index = 0
        max_len = 1
        for i in range(n):
            dp[i][i] = True
        for i in range(n - 1):
            dp[i][i + 1] = s[i] == s[i + 1]
            if dp[i][i + 1]:
                max_len = 2
                start_index = i
        for sub_str_len in range(3, n + 1):
            for i in range(n - sub_str_len + 1):
                dp[i][i + sub_str_len - 1] = s[i] == s[i +sub_str_len - 1] and dp[i + 1][i + sub_str_len - 2]
                if dp[i][i + sub_str_len - 1]:
                    start_index = i
                    max_len = sub_str_len
        return s[start_index: start_index + max_len]