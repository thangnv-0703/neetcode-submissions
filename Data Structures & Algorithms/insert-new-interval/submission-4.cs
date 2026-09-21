public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var n = intervals.Length;
        if (n == 0)
        {
            return new int [1][] { newInterval };
        }
        List<int[]> res = new List<int[]> ();
        for (var i=0; i<n; i++)
        {
            var interval = intervals[i];
            if (interval[1] < newInterval[0])
            {
                res.Add(interval);
            }
            else if (interval[0] > newInterval[1])
            {
                res.Add(newInterval);
                res.AddRange(intervals[i..]);
                return res.ToArray();
            }
            else
            {
                newInterval[0] = Math.Min(interval[0], newInterval[0]);
                newInterval[1] = Math.Max(interval[1], newInterval[1]);
            }
        }
        res.Add(newInterval);
        return res.ToArray();
    }
}
