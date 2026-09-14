public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        int [] memo = new int [s.Length];
        return Dfs(0, wordDict, s, memo);
    }

    public bool Dfs(int index, List<string> wordDict, string s, int[] memo)
    {
        if (index == s.Length)
        {
            return true;
        }
        if (memo[index] == -1)
        {
            return false;
        }
        for (var i = index; i < s.Length; i++)
        {
            foreach(var word in wordDict)
            {
                if (index + word.Length <= s.Length && s.Substring(index, word.Length) == word)
                {
                    if (Dfs(index + word.Length, wordDict, s, memo))
                    {
                        return true;
                    }
                }
            }
        }
        memo[index] = -1;
        return false;
    }
}
