public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = Int32.MinValue, curSum = 0;

        for(int i = 0; i < nums.Length; i++) {
            maxSum = Math.Max(maxSum, curSum + nums[i]);

            if(curSum + nums[i] <= 0) {
                curSum = 0;
            } else {
                curSum += nums[i];
            }
        }

        return maxSum;
        // return Math.Max(maxSum, nums[nums.Length - 1]);
    }
}