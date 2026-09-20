public class Solution {
    public int[][] Merge(int[][] intervals) {
        var intervalList = intervals.OrderBy(x => x[0]);
        var curInterval = intervalList.First();
        var res = new List<int[]> ();
        foreach (var interval in intervalList)
        {
            if (curInterval[1] < interval[0])
            {
                res.Add(curInterval);
                curInterval = interval;
            }
            else 
            {
                curInterval[1] = Math.Max(interval[1], curInterval[1]);
            }
        }
        res.Add(curInterval);
        return res.ToArray();
    }
}
