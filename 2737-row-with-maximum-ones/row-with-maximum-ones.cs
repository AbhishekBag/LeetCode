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

        /*
        for(int j = 0; j < mat[0].Length; j++) {
            for(int i = 0; i < mat.Length; i++) {
                if(mat[i][j] == 1) {
                    return new int[2] { i, mat[0].Length - j};
                }
            }
        }

        return new int[2] { 0, 0 };
        */
    }
}