class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        count = 0
        for r in range(len(grid)):
            for c in range(len(grid[0])):
                if grid[r][c] == '1':
                    self.dfs(grid, r, c)
                    count += 1
        return count
    
    def dfs(self, grid: [List[List[str]]], row: int, col: int) -> None:
        grid[row][col] = '2'
        directions = [(-1, 0), (0, - 1), (0, 1), (1, 0)]
        for d in directions:
            new_row, new_col = row + d[0], col + d[1]
            if self.is_within_range(grid, new_row, new_col) and grid[new_row][new_col] == '1':
                self.dfs(grid, new_row, new_col)

    def is_within_range(self, grid: [List[List[str]]], row: int, col: int) -> bool:
        return 0 <= row < len(grid) and 0 <= col < len(grid[0])