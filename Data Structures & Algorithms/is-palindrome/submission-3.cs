public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left += 1;
            }
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right -= 1;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left += 1;
            right -= 1;
        }
        return true;
    }
}
