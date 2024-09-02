public class Solution {
    private int[] dp;
    public int ClimbStairs(int n) {
        if(n <= 2) {
            return n;
        }

        int cur = 1;
        int prev1 = 1, prev2 = 0;

        for(int i = 1; i <= n; i++) {
            cur = prev1 + prev2;
            prev2 = prev1;
            prev1 = cur;
        }

        return cur;

        // dp = new int[n + 1];
        // return CountPaths(n);
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