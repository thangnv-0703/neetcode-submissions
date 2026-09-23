"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""
import heapq

class Solution:
    def minMeetingRooms(self, intervals: List[Interval]) -> int:
        intervals.sort(key= lambda x: x.start)
        if len(intervals) < 2:
            return len(intervals)
        heap = []
        heapq.heappush(heap, intervals[0].end)
        res = 1
        for interval in intervals[1:]:
            first_meeting_end = heap[0]
            if first_meeting_end <= interval.start:
                heapq.heappop(heap)
                res -= 1
            heapq.heappush(heap, interval.end)
            res += 1
        return res