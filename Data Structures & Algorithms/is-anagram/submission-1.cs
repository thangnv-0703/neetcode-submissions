public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> charCounts = new();

        // Vòng lặp thứ nhất: Đếm số lần xuất hiện của các ký tự
        for (int i = 0; i < s.Length; i++)
        {
            // Cộng 1 khi gặp ký tự ở chuỗi s
            charCounts[s[i]] = charCounts.GetValueOrDefault(s[i], 0) + 1;
            
            // Trừ 1 khi gặp ký tự ở chuỗi t
            charCounts[t[i]] = charCounts.GetValueOrDefault(t[i], 0) - 1;
        }

        // Vòng lặp thứ hai: Kiểm tra xem tất cả các giá trị đếm có bằng 0 hay không
        foreach (var count in charCounts.Values)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
}
