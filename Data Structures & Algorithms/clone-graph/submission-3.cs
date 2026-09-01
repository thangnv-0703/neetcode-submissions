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
        Queue<Node> queue = new ();
        queue.Enqueue(node);
        var newNode = new Node(node.val);
        clonedMap[node] = newNode;
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            var clonedNode = clonedMap[currentNode];
            foreach(var neighbor in currentNode.neighbors)
            {
                if (!clonedMap.ContainsKey(neighbor))
                {
                    var clonedNeighbor = new Node(neighbor.val);
                    clonedMap[neighbor] = clonedNeighbor;
                    queue.Enqueue(neighbor);
                }
                clonedNode.neighbors.Add(clonedMap[neighbor]);
            }
        }
        return clonedMap[node];
        // return Dfs(node, clonedMap);
    }

    // private Node Dfs(Node node, Dictionary<Node, Node> clonedMap)
    // {
    //     if (clonedMap.ContainsKey(node))
    //     {
    //         return clonedMap[node];
    //     }

    //     var clonedNode = new Node(node.val);
    //     clonedMap[node] = clonedNode;
    //     foreach(var neighbor in node.neighbors)
    //     {
    //         var clonedNeighbor = Dfs(neighbor, clonedMap);
    //         clonedNode.neighbors.Add(clonedNeighbor);
    //     }
    //     return clonedNode;
    // }
}
