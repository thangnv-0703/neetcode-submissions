/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node is null)
        {
            return node;
        }
        var clonedMap = new Dictionary<Node, Node>();
        return Dfs(node, clonedMap);
    }

    private Node Dfs(Node node, Dictionary<Node, Node> clonedMap)
    {
        if (clonedMap.ContainsKey(node))
        {
            return clonedMap[node];
        }

        var clonedNode = new Node(node.val);
        clonedMap[node] = clonedNode;
        foreach(var neighbor in node.neighbors)
        {
            var clonedNeighbor = Dfs(neighbor, clonedMap);
            clonedNode.neighbors.Add(clonedNeighbor);
        }
        return clonedNode;
    }
}
