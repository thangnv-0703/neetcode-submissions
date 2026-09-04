class Solution:
    def validTree(self, n: int, edges: List[List[int]]) -> bool:
        if len(edges) != n - 1:
            return False
        graph = defaultdict(list)
        visited = set()
        for edge in edges:
            graph[edge[0]].append(edge[1])
            graph[edge[1]].append(edge[0])
        # queue = deque([])
        # queue.append((edges[0][0], -1))
        # while queue:
        #     node, parent = queue.popleft()
        #     if node in visited:
        #         return False
        #     visited.add(node)
        #     for neighbor in graph[node]:
        #         if neighbor == parent:
        #             continue
        #         queue.append((neighbor, node))
        self.dfs(0, visited, graph)
        return len(visited) == n  

    def dfs(self, node: int, visited: set, graph: dict) -> None:
        visited.add(node)
        for neighbor in graph[node]:
            if neighbor not in visited:
                self.dfs(neighbor, visited, graph)           