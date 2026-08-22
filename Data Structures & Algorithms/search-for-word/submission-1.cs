public class Solution {
    public bool Exist(char[][] board, string word) {
        var m = board.Length;
        var n = board[0].Length;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Backtrack(board, word, 0, i, j))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool Backtrack(char[][] board, string word, int wordIndex, int row, int col)
    {
        if (word.Length - 1 == wordIndex)
        {
            return word[wordIndex] ==  board[row][col];
        } 
        if (word[wordIndex] != board[row][col])
        {
            return false;
        }

        var temp = board[row][col];
        board[row][col] = '0';

        List<(int, int)> directions = new () 
        {
            (0, -1),
            (-1, 0),
            (0, 1),
            (1, 0)
        };
        foreach(var dir in directions)
        {
            int newRow = row + dir.Item1;
            int newCol = col + dir.Item2;
            if (IsWithinBound(board, newRow, newCol))
            {
                if (Backtrack(board, word, wordIndex + 1, newRow, newCol))
                {
                    return true;
                }
            }
        }
        board[row][col] = temp;
        return false;
    }

    public bool IsWithinBound(char[][] board, int row, int col)
    {
        return row >= 0 && row < board.Length && col >= 0 && col < board[0].Length;
    }
}
