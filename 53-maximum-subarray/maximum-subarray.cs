public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = Int32.MinValue;
        int curSum = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(curSum < 0) {
                curSum = 0;
            }

            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}