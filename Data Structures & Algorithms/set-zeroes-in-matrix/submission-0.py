class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        row_zero = set()
        col_zero = set()
        m, n = len(matrix), len(matrix[0])
        for i in range(m):
            for j in range(n):
                if matrix[i][j] == 0:
                    row_zero.add(i)
                    col_zero.add(j)
        for i in range(m):
            for j in range(n):
                if i in row_zero or j in col_zero:
                    matrix[i][j] = 0
        