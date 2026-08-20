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
    public int KthSmallest(TreeNode root, int k) {
        var sortedList = Inorder(root);
        return sortedList[k - 1];
    }

    public int[] Inorder(TreeNode node) 
    {
        if (node is null)
        {
            return new int[] {};
        }
        return Inorder(node.left).Concat(new int [] { node.val }).Concat(Inorder(node.right)).ToArray();
    }
}
