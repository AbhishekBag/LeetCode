public class Solution {
    private int[] dp;
    public int ClimbStairs(int n) {
        dp = new int[n + 1];
        return CountPaths(n);
    }

    private int CountPaths(int n) {
        if(n <= 2) {
            return n;
        }

        if(dp[n] != 0) {
            return dp[n];
        }

        var paths = CountPaths(n - 1) + CountPaths(n - 2);
        dp[n] = paths;

        return paths;
    }
}