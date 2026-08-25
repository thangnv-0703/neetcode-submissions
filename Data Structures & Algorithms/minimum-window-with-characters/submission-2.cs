public class Solution {
    public string MinWindow(string s, string t) {
        var targetFreq = new Dictionary<char, int>();
        var windowFreq = new Dictionary<char, int>();
        foreach(var c in t)
        {
            targetFreq[c] = targetFreq.GetValueOrDefault(c, 0) + 1;
        }
        int left = 0;
        int matchedChar = 0;
        int startIndex = -1;
        int minLength = int.MaxValue;
        for (var right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];
            windowFreq[currentChar] = windowFreq.GetValueOrDefault(currentChar, 0) + 1;
            if (targetFreq.ContainsKey(currentChar) 
                && windowFreq.GetValueOrDefault(currentChar, 0) <= targetFreq[currentChar])
            {
                matchedChar += 1;
            }

            while (t.Length == matchedChar)
            {
                int currentWindow = right - left + 1;
                if (currentWindow < minLength)
                {
                    startIndex = left;
                    minLength = currentWindow;
                }

                char leftChar = s[left];
                if (targetFreq.ContainsKey(leftChar) 
                    && windowFreq.GetValueOrDefault(leftChar, 0) <= targetFreq[leftChar])
                {
                    matchedChar--;
                }
                windowFreq[leftChar] = windowFreq.GetValueOrDefault(leftChar, 0) - 1;
                left++;
            }
        }
        return startIndex == -1 ? string.Empty : s[startIndex..(startIndex + minLength)];
    }
}
