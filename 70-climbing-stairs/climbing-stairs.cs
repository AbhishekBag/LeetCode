public class Solution {
    private int[] dp;
    public int ClimbStairs(int n) {
        dp = Enumerable.Repeat(-1, n + 1).ToArray();
        return Climb(n);
    }

    private int Climb(int n) {
        if(n <= 2) {
            return n;
        }

        if(dp[n] != -1) {
            return dp[n];
        }

        dp[n] = Climb(n - 1) + Climb(n - 2);
        return dp[n];
    }
}