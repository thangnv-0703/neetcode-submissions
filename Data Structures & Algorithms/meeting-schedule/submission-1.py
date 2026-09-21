"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""

class Solution:
    def canAttendMeetings(self, intervals: List[Interval]) -> bool:
        if not len(intervals):
            return True
        intervals.sort(key = lambda x: x.start)
        cur_interval = intervals[0]
        for interval in intervals[1:]:
            if cur_interval.end > interval.start:
                return False
            cur_interval = interval
        return True