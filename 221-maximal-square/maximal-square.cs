public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int r = matrix.Length;
        int c = matrix[0].Length;
        int[][] dp = new int[r][];
        int max = 0;

        for(int i = 0; i < r; i++) {
            dp[i] = Enumerable.Repeat(0, c).ToArray();
            // dp[i][0] = (int)(matrix[i][0] - '0');

            // max = Math.Max(max, dp[i][0]);
        }

        // for(int j = 0; j < c; j++) {
        //     dp[0][j] = (int)(matrix[0][j] - '0');

        //     max = Math.Max(max, dp[0][j]);
        // }

        // for(int i = 0; i < r; i++) {
        //     for(int j = 0; j < c; j++) {
        //     }
        // }

        for(int i = 0; i < r; i++) {
            for(int j = 0; j < c; j++) {
                if(i == 0 || j == 0) {
                    dp[i][j] = (int)(matrix[i][j] - '0');
                    max = Math.Max(max, dp[i][j]);
                } else {
                    if(matrix[i][j] == '0') {
                        dp[i][j] = 0;
                    } else {
                        dp[i][j] = Math.Min(dp[i - 1][j - 1],
                            Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;

                        max = Math.Max(max, dp[i][j]);
                    }
                }

                
            }
        }

        return max * max;       
    }
}