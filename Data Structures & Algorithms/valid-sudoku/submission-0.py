class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        row_set = [set() for _ in range(9)]
        col_set = [set() for _ in range(9)]
        box_set = [[set() for _ in range(3)] for _ in range(3)]
        for i in range(9):
            for j in range(9):
                cell = board[i][j]
                if cell == ".":
                    continue
                if cell in row_set[i] or cell in col_set[j] or cell in box_set[i // 3][j // 3]:
                    return False
                row_set[i].add(cell)
                col_set[j].add(cell)
                box_set[i // 3][j // 3].add(cell)
        return True