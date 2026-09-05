public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<int>[] graph = new List<int>[n];
        HashSet<int> visited = new ();
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int> ();
        }
        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        int count = 0;
        for(int node = 0; node < n; node++)
        {
            if (visited.Contains(node))
            {
                continue;
            }
            Dfs(node, visited, graph);
            count++;
        }
        return count;
    }

    public void Dfs(int node, HashSet<int> visited, List<int>[] graph)
    {
        visited.Add(node);
        foreach(var neighbor in graph[node])
        {
            if (!visited.Contains(neighbor))
            {
                Dfs(neighbor, visited, graph);
            }
        }
    }
}
