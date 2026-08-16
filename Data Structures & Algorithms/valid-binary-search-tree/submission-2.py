# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        return self.isValid(root, float('-inf'), float('inf'))
        
    def isValid(self, node: Optional[TreeNode], lower_bound: float, upper_bound: float) -> bool:
        if not node:
            return True
        if not lower_bound < node.val < upper_bound:
            print(node.val, lower_bound, upper_bound)
            return False
        return self.isValid(node.left, lower_bound, node.val) and self.isValid(node.right, node.val, upper_bound)
        