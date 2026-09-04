class Solution:
    def validTree(self, n: int, edges: List[List[int]]) -> bool:
        if len(edges) == 0:
            return True
        if len(edges) < n - 1:
            return False
        graph = defaultdict(list)
        visited = set()
        for edge in edges:
            graph[edge[0]].append(edge[1])
            graph[edge[1]].append(edge[0])
        queue = deque([])
        queue.append((edges[0][0], -1))
        while queue:
            node, parent = queue.popleft()
            if node in visited:
                return False
            visited.add(node)
            for neighbor in graph[node]:
                if neighbor == parent:
                    continue
                queue.append((neighbor, node))
        return len(visited) == n            