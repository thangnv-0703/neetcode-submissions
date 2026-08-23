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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) 
    {
        if (root is null)
        {
            return false;
        }
        if (MatchTree(root, subRoot))
        {
            return true;
        }
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool MatchTree(TreeNode node1, TreeNode node2)
    {
        if (node1 is null && node2 is null)
        {
            return true;
        }
        if (node1 is null || node2 is null || node1.val != node2.val)
        {
            return false;
        }
        return MatchTree(node1.left, node2.left) && MatchTree(node1.right, node2.right);
    }
}
