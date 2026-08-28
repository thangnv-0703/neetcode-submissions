# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque

class Codec:
    
    # Encodes a tree to a single string.
    def serialize(self, root: Optional[TreeNode]) -> str:
        if not root:
            return '#'
        queue = deque([root])
        res = []
        while queue:
            node = queue.popleft()
            if not node:
                res.append('#')
                continue
            res.append(str(node.val))
            queue.append(node.left)
            queue.append(node.right)
        return ','.join(res)
        
    # Decodes your encoded data to tree.
    def deserialize(self, data: str) -> Optional[TreeNode]:
        values = data.split(',')
        if not values or values[0] == '#':
            return None
        root = TreeNode(values[0])
        queue = deque([root])
        index = 1

        while queue:
            node = queue.popleft()
            if (values[index] != '#'):
                node.left = TreeNode(int(values[index]))
                queue.append(node.left)
            index += 1
            if (values[index] != '#'):
                node.right = TreeNode(int(values[index]))
                queue.append(node.right)
            index += 1
        return root