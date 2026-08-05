class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        is_first_row_zero = False
        is_first_col_zero = False
        m, n = len(matrix), len(matrix[0])
        for i in range(m):
            if matrix[i][0] == 0:
                is_first_col_zero = True
                break
        for j in range(n):
            if matrix[0][j] == 0:
                is_first_row_zero = True
                break
        for i in range(1, m):
            for j in range(1, n):
                if matrix[i][j] == 0:
                    matrix[i][0] = 0
                    matrix[0][j] = 0
        for i in range(1, m):
            for j in range(1, n):
                if matrix[i][0] == 0 or matrix[0][j] == 0:
                    matrix[i][j] = 0
        if is_first_row_zero:
            for j in range(n):
                matrix[0][j] = 0
        if is_first_col_zero:
            for i in range(m):
                matrix[i][0] = 0
