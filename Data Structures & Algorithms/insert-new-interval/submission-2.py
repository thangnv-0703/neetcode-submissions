class Solution:
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        if not len(intervals):
            return [newInterval]
        res = []
        is_add_new = False
        for i in range(len(intervals)):
            interval = intervals[i]
            if interval[1] < newInterval[0]:
                res.append(interval)
                is_add_new = True
            elif interval[0] > newInterval[1]:
                res.append(newInterval)
                res.extend(intervals[i:])
                is_add_new = False
                break
            else:
                is_add_new = True
                newInterval[1] = max(interval[1], newInterval[1])
                newInterval[0] = min(interval[0], newInterval[0])
        if is_add_new:
            res.append(newInterval)
        return res