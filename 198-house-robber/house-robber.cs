public class Solution {
    private int[] dp;
    public int Rob(int[] nums) {
        dp = Enumerable.Repeat(-1, nums.Length + 1).ToArray();
        return RobHouse(nums, 0);
    }

    private int RobHouse(int[] nums, int i) {
        if(i >= nums.Length) {
            return 0;
        }

        if(dp[i] != -1) {
            return dp[i];
        }

        dp[i] = Math.Max(nums[i] + RobHouse(nums, i + 2), RobHouse(nums, i + 1));
        return dp[i];
    }
}