public class Solution {
    public void Rotate(int[][] matrix) {
        int l = 0, r = matrix.Length-1;

        while (l<r)
        {
            for(int i = 0;i<(r-l);i++)
            {
                int top = l, bottom = r;

                int topleft = matrix[top][l+i];

                matrix[top][l+i] = matrix[bottom-i][l];

                matrix[bottom-i][l] = matrix[bottom][r-i];

                matrix[bottom][r-i] = matrix[top+i][r];

                matrix[top+i][r] = topleft;

            }
            r--;
            l++;
        }
    }
}
