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
        queue = deque([node])
        graph_map = {}
        graph_map[node] = Node(node.val)
        while queue:
            cur_node = queue.popleft()
            for neighbor in cur_node.neighbors:
                if neighbor not in graph_map:
                    graph_map[neighbor] = Node(neighbor.val)
                    queue.append(neighbor)
                graph_map[cur_node].neighbors.append(graph_map[neighbor])
        return graph_map[node]