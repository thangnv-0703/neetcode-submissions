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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);
        var result = new List<string>();
        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            if (node is null)
            {
                result.Add("#");
                continue;
            }
            result.Add(node.val.ToString());
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
        return string.Join(",", result);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] values = data.Split(',');
        if (values.Length == 0 || values[0] == "#")
        {
            return null;
        }
        var root = new TreeNode(int.Parse(values[0]));
        var index = 1;
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            var node = queue.Dequeue();
            if (values[index] != "#")
            {
                node.left = new TreeNode(int.Parse(values[index]));
                queue.Enqueue(node.left);
            }
            index++;
            if (values[index] != "#")
            {
                node.right = new TreeNode(int.Parse(values[index]));
                queue.Enqueue(node.right);
            }
            index++;
        }
        return root;
    }
}
