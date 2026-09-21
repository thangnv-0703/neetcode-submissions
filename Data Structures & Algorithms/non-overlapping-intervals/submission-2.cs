public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => (a[0], a[1]).CompareTo((b[0], b[1])));
        var n = intervals.Length;
        var curInterval = intervals[0];
        var count = 0;
        for (var i=1; i<n; i++)
        {
            var interval = intervals[i];
            if (curInterval[1] > interval[0])
            {
                count++; 
                curInterval = curInterval[1] > interval[1] ? interval : curInterval;               
            }
            else
            {
                curInterval = interval;
            }
        }
        return count;
    }
}
