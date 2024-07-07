public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();
        int res = 1;

        for(int i = nums.Length - 1; i >= 0; i--) {
            for(int j = i + 1; j < nums.Length; j++) {
                if(nums[i] < nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    res = Math.Max(res, dp[i]);
                }
            }
        }

        return res;
    }
}