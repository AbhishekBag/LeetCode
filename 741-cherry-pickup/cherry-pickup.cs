public class Solution {
    private int[][][] dp;
    private int[][] grid;
    private int n;
    public int CherryPickup(int[][] grid) {
        n = grid.Length;
        this.grid = grid;
        dp = new int[n][][];
        // for(int i = 0; i < n; i++) {
            // dp[i] = new int[n][][];
            for(int j = 0; j < n; j++) {
                // dp[i][j] = new int[n][];
                dp[j] = new int[n][];
                for(int k = 0; k < n; k++) {
                    // dp[i][j][k] = Enumerable.Repeat(-1, n).ToArray();
                    dp[j][k] = Enumerable.Repeat(-1, n).ToArray();
                }
            }
        // }

        var maxCherries = GetMaxCherry(0, 0, 0);
        if(maxCherries < 0) {
            return 0;
        }

        return maxCherries;
    }

    private int GetMaxCherry(int c1, int r2, int c2) {
        var r1 = r2 + c2 - c1;
        if(r1 >= n || r2 >= n || c1 >= n || c2 >= n || grid[r1][c1] == -1 || grid[r2][c2] == -1) {
            return Int32.MinValue;
        }

        if(dp[c1][r2][c2] != -1) {
            return dp[c1][r2][c2];
        }

        int v1 = grid[r1][c1];
        int v2 = grid[r2][c2];
        int cherries = 0;

        if(r1 == r2 && c1 == c2) {
            cherries += grid[r1][c1];
            if(r1 == n - 1 && c1 == n -1) {
                // dp[c1][r2][c2] = grid[r1][c1];
                // return dp[c1][r2][c2];
                return grid[r1][c1];
            }
            grid[r1][c1] = 0;
        } else {
            cherries += grid[r1][c1] + grid[r2][c2];
            grid[r1][c1] = 0;
            grid[r2][c2] = 0;
        }

        int p1 = GetMaxCherry(c1, r2 + 1, c2);
        int p2 = GetMaxCherry(c1, r2, c2 + 1);
        int p3 = GetMaxCherry(c1 + 1, r2, c2 + 1);
        int p4 = GetMaxCherry(c1 + 1, r2 + 1, c2);

        grid[r1][c1] = v1;
        grid[r2][c2] = v2;

        dp[c1][r2][c2] = cherries + Math.Max(Math.Max(p1, p2), Math.Max(p3, p4));

        return dp[c1][r2][c2];
    }
}