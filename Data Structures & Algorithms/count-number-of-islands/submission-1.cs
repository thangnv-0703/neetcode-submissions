public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[0].Length; c++)
            {
                if (grid[r][c] == '1')
                {
                    Dfs(grid, r, c);
                    count++;
                }
            }
        }
        return count;
    }

    public void Dfs(char[][] grid, int row, int col)
    {
        grid[row][col] = '2';
        List<(int Horizontal, int Vertical)> directions = new ()
        {
            (-1, 0),
            (0, -1),
            (1, 0),
            (0, 1),
        };
        foreach (var item in directions)
        {
            var newRow = item.Horizontal + row;
            var newCol = item.Vertical + col;
            if (IsWithinRange(grid, newRow, newCol) && grid[newRow][newCol] == '1')
            {
                Dfs(grid, newRow, newCol);
            }
        }
    }

    public bool IsWithinRange(char[][] grid, int row, int col)
    {
        return (row >= 0 && row < grid.Length) && (col >= 0 && col < grid[0].Length);
    }
}
