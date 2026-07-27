from collections import Counter
import heapq

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        element_count = Counter(nums)
        n = len(nums)
        bucket_list = [[] for _ in range(n + 1)]
        for element, freq in element_count.items():
            bucket_list[freq].append(element)
        result = []
        for freq in range(n, 0, -1):
            for item in bucket_list[freq]:
                result.append(item)
                if len(result) == k:
                    return result
        return result
            