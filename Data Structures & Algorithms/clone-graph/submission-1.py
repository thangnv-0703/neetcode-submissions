"""
# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []
"""

class Solution:
    def cloneGraph(self, node: Optional['Node']) -> Optional['Node']:
        if not node:
            return node
        graph_map = {}
        return self.dfs(graph_map, node)

        # queue = deque([node])
        # graph_map[node] = Node(node.val)
        # while queue:
        #     cur_node = queue.popleft()
        #     for neighbor in cur_node.neighbors:
        #         if neighbor not in graph_map:
        #             graph_map[neighbor] = Node(neighbor.val)
        #             queue.append(neighbor)
        #         graph_map[cur_node].neighbors.append(graph_map[neighbor])
        # return graph_map[node]

    def dfs(self, graph_map: Dictionary, node: Optional[Node]):
        if node in graph_map:
            return graph_map[node]

        clone_node = Node(node.val)
        graph_map[node] = clone_node
        for neighbor in node.neighbors:
            clone_neighbor = self.dfs(graph_map, neighbor)
            clone_node.neighbors.append(clone_neighbor)
        return clone_node