public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var indegrees = new int [numCourses];
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }
        var queue = new Queue<int> ();
        foreach(var p in prerequisites)
        {
            indegrees[p[1]] += 1;
            graph[p[0]].Add(p[1]);
        }
        for(var i = 0; i < indegrees.Length; i++)
        {
            if (indegrees[i] == 0)
            {
                queue.Enqueue(i);
            }
        }
        var enrolledCourses = 0;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            enrolledCourses += 1;
            foreach(var neighbor in graph[node])
            {
                indegrees[neighbor] -= 1;
                if (indegrees[neighbor] == 0)
                {
                    queue.Enqueue(neighbor);
                }
            }
        }
        return numCourses == enrolledCourses;
    }
}
