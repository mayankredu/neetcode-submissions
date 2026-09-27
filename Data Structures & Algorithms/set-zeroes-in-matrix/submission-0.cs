public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        bool[] zeroRows = new bool[rows];
        bool[] zeroCols = new bool[cols];

        for(int i = 0; i < rows;i++)
        {
            for(int j = 0;j<cols;j++)
            {
                if(matrix[i][j]==0)
                {
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }

        for(int i = 0; i < rows;i++)
        {
            for(int j = 0;j<cols;j++)
            {
                if(zeroRows[i] || zeroCols[j] )
                {
                    matrix[i][j] = 0;
                }
            }

        }
    }

}
