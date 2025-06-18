public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int maxCount = 0;
        int maxRow = 0;

        for(int i = 0; i < mat.Length; i++) {
            int count = 0;
            for(int j = 0; j < mat[0].Length; j++) {
                if(mat[i][j] == 1) {
                    count++;
                }
            }

            if(maxCount < count) {
                maxCount = count;
                maxRow = i;
            }
        }

        return new int[] { maxRow, maxCount };
    }
}