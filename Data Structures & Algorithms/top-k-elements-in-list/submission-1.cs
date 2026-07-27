public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counters = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        int n = nums.Length;
        List<int>[] buckets = new List<int>[n + 1];
        for (int i = 0; i <= n; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach (var (key, value) in counters)
        {
            buckets[value].Add(key);
        }
        List<int> result = new ();
        for (int j = n; j >= 0; j--)
        {
            foreach(var item in buckets[j])
            {
                result.Add(item);
                if (result.Count == k)
                    return result.ToArray();
            }
        }
        return result.ToArray();
    }
}
