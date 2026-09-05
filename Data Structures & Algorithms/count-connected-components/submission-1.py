class Solution:
    def countComponents(self, n: int, edges: List[List[int]]) -> int:
        graph = defaultdict(list)
        visited = set()
        count = 0
        for edge in edges:
            graph[edge[0]].append(edge[1])
            graph[edge[1]].append(edge[0])
        for node in range(n):
            if node not in visited:
                self.dfs(node, visited, graph)
                count += 1
        return count
        
    def dfs(self, node: int, visited: set, graph: dict) -> None:
        visited.add(node)
        for neighbor in graph[node]:
            if neighbor not in visited:
                self.dfs(neighbor, visited, graph)
