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
    private int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        CalculateGain(root);
        return maxSum;
    }

    private int CalculateGain(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }
        int leftGain = Math.Max(CalculateGain(node.left), 0);
        int rightGain = Math.Max(CalculateGain(node.right), 0);
        int currentGain = leftGain + rightGain + node.val;
        maxSum = Math.Max(currentGain, maxSum);
        return Math.Max(leftGain, rightGain) + node.val;
    }
}
