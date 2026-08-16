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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, double.NegativeInfinity, double.PositiveInfinity);
    }

    public bool IsValid(TreeNode node, double lowerBound, double upperBound)
    {
        if (node is null)
        {
            return true;
        }
        if (node.val >= upperBound || node.val <= lowerBound)
        {
            return false;
        }
        return IsValid(node.left, lowerBound, node.val) && IsValid(node.right, node.val, upperBound);
    }
}
