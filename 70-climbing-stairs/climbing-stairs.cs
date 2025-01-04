public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) {
            return n;
        }

        int cur = 0;
        int prev1 = 2, prev2 = 1;

        for(int i = 3; i <= n; i++) {
            cur = prev1 + prev2;
            prev2 = prev1;
            prev1 = cur;
        }

        return cur;
    }
}