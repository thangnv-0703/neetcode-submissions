# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        sorted_list = self.inorder(root)
        return sorted_list[k - 1]
        
    def inorder(self, node: Optional[TreeNode]) -> List[int]:
        if not node:
            return []
        return self.inorder(node.left) + [node.val] + self.inorder(node.right)
    