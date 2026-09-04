public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1)
        {
            return false;
        }
        List<int>[] graph = new List<int> [n];
        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<int> ();
        } 
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        HashSet<int> visited = new ();
        Dfs(0, graph, visited);
        return visited.Count == n;
    }

    private void Dfs(int node, List<int>[] graph, HashSet<int> visited)
    {
        visited.Add(node);
        foreach (var neighbor in graph[node])
        {
            if (!visited.Contains(neighbor))
            {
                Dfs(neighbor, graph, visited);
            }
        }
    }
}
