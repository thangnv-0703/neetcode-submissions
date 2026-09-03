from collections import deque, defaultdict

class Solution:
    def canFinish(self, numCourses: int, prerequisites: List[List[int]]) -> bool:
        indegrees = [0] * numCourses
        queue = deque([])
        graph = defaultdict(list)
        for pre in prerequisites:
            indegrees[pre[1]] += 1
            graph[pre[0]].append(pre[1])
        for i in range(len(indegrees)):
            if indegrees[i] == 0:
                queue.append(i)
        enrolled_course = 0
        while queue:
            node = queue.popleft()
            enrolled_course += 1
            for neighbor in graph[node]:
                indegrees[neighbor] -= 1
                if indegrees[neighbor] == 0:
                    queue.append(neighbor)
        return enrolled_course == numCourses