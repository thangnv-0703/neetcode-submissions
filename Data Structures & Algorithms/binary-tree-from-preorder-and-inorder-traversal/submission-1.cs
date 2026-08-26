/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int preorderIdx = 0;
    Dictionary<int, int> inorderIndexesMap = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {
        for(var i = 0; i < inorder.Length; i++)
        {
            inorderIndexesMap[inorder[i]] = i;
        }    
        return BuildSubTree(0, preorder.Length - 1, preorder);
    }

    public TreeNode BuildSubTree(int left, int right, int[] preorder)
    {
        if (left > right)
        {
            return null;
        }
        var currentVal = preorder[preorderIdx++];
        var node = new TreeNode(currentVal);
        var inorderIdx = inorderIndexesMap[currentVal];
        node.left = BuildSubTree(left, inorderIdx - 1, preorder);
        node.right = BuildSubTree(inorderIdx + 1, right, preorder);
        return node;
    }
}
