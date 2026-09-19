class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals.sort(key = lambda x:x[0])
        cur_interval = intervals[0]
        res = []
        for interval in intervals[1:]:
            if interval[0] > cur_interval[1]:
                res.append(cur_interval)
                cur_interval = interval
            else:
                cur_interval[1] = max(interval[1], cur_interval[1])
        res.append(cur_interval)
        return res