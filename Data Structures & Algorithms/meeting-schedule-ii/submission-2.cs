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
    public int MinMeetingRooms(List<Interval> intervals) {
        intervals.Sort((x, y) => x.start.CompareTo(y.start));
        var heap = new PriorityQueue<int, int>();
        foreach(var interval in intervals)
        {
            if (heap.Count > 0 && heap.Peek() <= interval.start)
            {
                heap.Dequeue();
            }
            heap.Enqueue(interval.end, interval.end);
        }
        return heap.Count;
    }
}
