public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) 
    {
        int m = heights.Length;
        int n = heights[0].Length;
        bool[][] pacific = new bool[m][];
        bool[][] atlantic = new bool[m][];
        for (int i = 0; i < m; i++)
        {
            pacific[i] = new bool[n];
            atlantic[i] = new bool[n];
        }
        List<List<int>> result = new ();
        for (var i = 0; i < m; i++)
        {
            Dfs(heights, i, 0, pacific);
            Dfs(heights, i, n - 1, atlantic);
        }
        for (var j = 0; j < n; j++)
        {
            Dfs(heights, 0, j, pacific);
            Dfs(heights, m - 1, j, atlantic);
        }
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (pacific[i][j] && atlantic[i][j])
                {
                    result.Add(new List<int> {i, j});
                }
            }
        }
        return result;
    }

    private void Dfs(int[][] heights, int row, int col, bool[][] ocean)
    {
        if (ocean[row][col] == true)
        {
            return;
        }
        ocean[row][col] = true;
        var directions = new List<(int, int)> ()
        {
            (0, -1),
            (-1, 0),
            (0, 1),
            (1, 0)
        };
        foreach (var d in directions)
        {
            int newRow = d.Item1 + row;
            int newCol = d.Item2 + col;
            if (IsWithinRange(newRow, newCol, heights) && heights[newRow][newCol] >= heights[row][col])
            {
                Dfs(heights, newRow, newCol, ocean);
            }
        }
    }

    private bool IsWithinRange(int row, int col, int[][] heights)
    {
        return (row >= 0 && row < heights.Length) && (col >= 0 && col < heights[0].Length);
    }
}
