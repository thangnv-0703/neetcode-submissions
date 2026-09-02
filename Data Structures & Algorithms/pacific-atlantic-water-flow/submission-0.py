class Solution:
    def pacificAtlantic(self, heights: List[List[int]]) -> List[List[int]]:
        m = len(heights)
        n = len(heights[0])
        pacific = [[False] * n for _ in range(m)]
        atlantic = [[False] * n for _ in range(m)]
        res = []

        for i in range(m):
            self.dfs(i, 0, pacific, heights)
            self.dfs(i, n - 1, atlantic, heights)
        for j in range(n):
            self.dfs(0, j, pacific, heights)
            self.dfs(m - 1, j, atlantic, heights)
        for i in range(m):
            for j in range(n):
                if pacific[i][j] and atlantic[i][j]:
                    res.append([i, j])
        return res

    def dfs(self, row: int, col: int, ocean: List[List[bool]], heights: List[List[int]]) -> None:
        if ocean[row][col]:
            return
        ocean[row][col] = True
        directions = [(0, -1), (-1, 0), (0, 1), (1, 0)]
        for d in directions:
            new_row, new_col = row + d[0], col + d[1]
            if self.is_within_range(new_row, new_col, heights) and heights[row][col] <= heights[new_row][new_col]:
                self.dfs(new_row, new_col, ocean, heights)

    def is_within_range(self, row: int, col: int, heights: List[List[int]]) -> bool:
        return 0 <= row < len(heights) and 0 <= col < len(heights[0])