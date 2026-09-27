public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
         List<int> res = new List<int>();
        // Handle empty matrix edge case
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) {
            return res;
        }

        // Initialize four pointers for the boundaries
        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while(left <= right && top <= bottom){
           for(int i = left;i<=right;i++)
           {
             res.Add(matrix[top][i]);
           }
           top++;

           for(int j = top ;j<=bottom;j++)
           {
             res.Add(matrix[j][right]);
           }
           right--;

        if (top <= bottom) {
           for(int i = right;i>=left;i--)
           {
             res.Add(matrix[bottom][i]);
           }
           bottom--;
             }

             if (left <= right) {
           for(int j = bottom;j>=top;j--)
           {
             res.Add(matrix[j][left]);
           }
           left++;
             }

           
        }

        return res;
    }
}
