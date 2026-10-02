class MedianFinder:

    def __init__(self):
        self.min_heap = []
        self.max_heap = []        

    def addNum(self, num: int) -> None:
        if not self.min_heap or self.min_heap[0] < num:
            heapq.heappush(self.min_heap, num)
        else:
            heapq.heappush(self.max_heap, -num)
        while abs(len(self.max_heap) - len(self.min_heap)) > 1:
            if len(self.max_heap) > len(self.min_heap):
                item = - heapq.heappop(self.max_heap)
                heapq.heappush(self.min_heap, item)
            else:
                item = heapq.heappop(self.min_heap)
                heapq.heappush(self.max_heap, -item)
                

    def findMedian(self) -> float:
        if len(self.max_heap) == len(self.min_heap):
            return (- self.max_heap[0] + self.min_heap[0]) / 2
        elif len(self.max_heap) > len(self.min_heap):
            return - self.max_heap[0]
        else:
            return self.min_heap[0]