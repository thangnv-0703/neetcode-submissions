public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxLength = 0;
        var prevIndexes = new Dictionary<char, int>();
        for (int right = 0; right < s.Length; right++)
        {
            if (prevIndexes.ContainsKey(s[right]))
            {
                left = Math.Max(left, prevIndexes[s[right]] + 1);
            }
            prevIndexes[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
