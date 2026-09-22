/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        var n  = intervals.Count;
        if (n == 0)
        {
            return true;
        }
        intervals = intervals.OrderBy(x => x.start).ToList();
        var prevEnd = intervals[0].end;
        for (var i = 1; i < n; i++)
        {
            var interval = intervals[i];
            if (prevEnd > interval.start)
            {
                return false;
            }
            else 
            {
                prevEnd = interval.end;
            }
        }
        return true;
    }
}
