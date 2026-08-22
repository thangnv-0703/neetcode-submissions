class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        m, n = len(board), len(board[0])
        for i in range(m):
            for j in range(n):
                if self.backtrack(board, word, 0, i, j):
                    return True
        return False

    def backtrack(self, board: List[List[str]], word: str, word_index: int, row: int, col: int) -> bool:
        if word_index == len(word) - 1:
            return board[row][col] == word[word_index]
        if board[row][col] != word[word_index]:
            return False

        temp = board[row][col]
        board[row][col] = "0"

        directions = [(-1, 0), (0, -1), (1, 0), (0, 1)]
        for d in directions:
            new_row, new_col = row + d[0], col + d[1]
            if self.is_within_bound(board, new_row, new_col):
                if self.backtrack(board, word, word_index + 1, new_row, new_col):
                    return True
        
        board[row][col] = temp
        return False

    def is_within_bound(self, board: List[List[str]], row: int, col: int) -> bool:
        return 0 <= row < len(board) and 0 <= col < len(board[0])
        