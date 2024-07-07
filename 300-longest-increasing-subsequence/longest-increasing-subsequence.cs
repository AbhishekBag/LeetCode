public class Solution {
    public int LengthOfLIS(int[] nums) {
        return GetLIS(nums);
        /*
        int[] map = Enumerable.Repeat(1, nums.Length).ToArray();

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] > nums[i - 1]) {
                map[i] = map[i - 1] + 1;
            } else {
                map[i] = map[i - 1];
            }
        }

        return map[nums.Length - 1];
        */
    }

    private int GetLIS(int[] nums) {
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