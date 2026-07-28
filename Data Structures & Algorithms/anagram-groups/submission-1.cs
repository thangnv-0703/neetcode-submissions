public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> wordMap = new();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (var c in s)
            {
                count[c - 'a']++;
            } 
            string hashKey = string.Join(",", count);
            if (!wordMap.ContainsKey(hashKey))
            {
                wordMap[hashKey] = new List<string>();
            }
            wordMap[hashKey].Add(s);
        }
        return wordMap.Values.ToList();
    }
}
