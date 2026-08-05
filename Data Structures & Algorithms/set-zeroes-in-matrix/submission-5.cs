public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        var isFirstRowZero = false;
        var isFirstColZero = false;
        for (var i = 0; i < m; i++)
        {
            if (matrix[i][0] == 0)
            {
                isFirstColZero = true;
                break;
            }
        }
        for (var j = 0; j < n; j++)
        {
            if (matrix[0][j] == 0)
            {
                isFirstRowZero = true;
                break;
            }
        }
        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        if (isFirstColZero)
        {
            for (var i = 0; i < m; i++)
                matrix[i][0] = 0;
        }
        if (isFirstRowZero)
        {
            for (var j = 0; j < n; j++)
                matrix[0][j] = 0;
        }
    }
}
