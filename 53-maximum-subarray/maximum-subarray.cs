public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = nums[0];

        for(int i = 1; i < nums.Length; i++) {
            if(curSum < 0) {
                curSum = 0;
            }

            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}