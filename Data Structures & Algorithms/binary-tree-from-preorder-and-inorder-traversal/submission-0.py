# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def buildTree(self, preorder: List[int], inorder: List[int]) -> Optional[TreeNode]:
        self.preorder_index = 0
        inorder_indexes_map = {}

        for idx, val in enumerate(inorder):
            inorder_indexes_map[val] = idx

        def build_subtree(left: int, right: int) -> Optional[TreeNode]:
            if left > right:
                return None
            val = preorder[self.preorder_index]
            self.preorder_index += 1
            inorder_index = inorder_indexes_map[val]
            node = TreeNode(val)
            node.left = build_subtree(left, inorder_index - 1)
            node.right = build_subtree(inorder_index + 1, right)
            return node
        
        return build_subtree(0, len(inorder) - 1)
        