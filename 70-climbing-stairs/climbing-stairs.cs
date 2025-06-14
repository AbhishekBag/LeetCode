public class Solution {
    public int ClimbStairs(int n) {
        int a = 0, b = 1, c = 1;

        for(int i = 1; i <= n; i++) {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
    // private int[] memo;
    // public int ClimbStairs(int n) {
    //     memo = Enumerable.Repeat(Int32.MaxValue, n + 1).ToArray();
    //     return CountWays(n);
    // }

    // private int CountWays(int n) {
    //     if(n <= 2) {
    //         return n;
    //     }

    //     if(memo[n] != Int32.MaxValue) {
    //         return memo[n];
    //     }

    //     memo[n] = CountWays(n - 1) + CountWays(n - 2);

    //     return memo[n];
    // }
}