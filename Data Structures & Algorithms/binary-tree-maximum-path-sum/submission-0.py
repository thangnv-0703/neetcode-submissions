# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def maxPathSum(self, root: Optional[TreeNode]) -> int:
        self.max_sum = float('-inf')
        def calculate_max_gain(node: Optional[TreeNode]) -> int:
            if node is None:
                return 0
            left_gain = max(calculate_max_gain(node.left), 0)
            right_gain = max(calculate_max_gain(node.right), 0)
            current_gain = left_gain + right_gain + node.val
            self.max_sum = max(current_gain, self.max_sum)
            return max(left_gain, right_gain) + node.val
        calculate_max_gain(root)
        return self.max_sum