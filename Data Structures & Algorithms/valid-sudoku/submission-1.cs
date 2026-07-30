public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rowSet = new HashSet<char>[9];
        HashSet<char>[] colSet = new HashSet<char>[9];
        HashSet<char>[,] boxSet = new HashSet<char>[3,3];
        for (var i = 0; i < 9; i++)
        {
            rowSet[i] = new HashSet<char>();
            colSet[i] = new HashSet<char>();
        }
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j ++)
            {
                boxSet[i,j] = new HashSet<char>();
            }
        }
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                char cell = board[i][j];
                if (cell == '.')
                    continue;
                if (rowSet[i].Contains(cell) || colSet[j].Contains(cell) || boxSet[i / 3, j / 3].Contains(cell))
                    return false;
                rowSet[i].Add(cell);
                colSet[j].Add(cell);
                boxSet[i / 3, j / 3].Add(cell);
            }
        }
        return true;
    }
}
