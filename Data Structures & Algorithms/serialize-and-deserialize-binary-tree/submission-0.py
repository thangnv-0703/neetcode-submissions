# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Codec:
    
    # Encodes a tree to a single string.
    def serialize(self, root: Optional[TreeNode]) -> str:
        # Perform a preorder traversal to add node values to a list, then convert the
        # list to a string.
        serialized_list = []
        self.preorder_serialize(root, serialized_list)
        # Convert the list to a string and separate each value using a comma
        # delimiter.
        return ','.join(serialized_list)
    
    # Helper function to perform serialization through preorder traversal.
    def preorder_serialize(self, node, serialized_list) -> None:
        # Base case: mark null nodes as '#'.
        if node is None:
            serialized_list.append('#')
            return
        # Preorder traversal processes the current node first, then the left and right
        # children.
        serialized_list.append(str(node.val))
        self.preorder_serialize(node.left, serialized_list)
        self.preorder_serialize(node.right, serialized_list)
        
    # Decodes your encoded data to tree.
    def deserialize(self, data: str) -> Optional[TreeNode]:
            # Obtain the node values by splitting the string using the comma delimiter.
        node_values = iter(data.split(','))
        return self.build_tree(node_values)

    # Helper function to construct the tree using preorder traversal.
    def build_tree(self, values: List[str]) -> TreeNode:
        val = next(values)
        # Base case: '#' indicates a null node.
        if val == '#':
            return None
        # Use preorder traversal processes the current node first, then the left and
        # right children.
        node = TreeNode(int(val))
        node.left = self.build_tree(values)
        node.right = self.build_tree(values)
        return node
