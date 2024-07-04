public class Solution {
    public int MaxSubArray(int[] nums) {
        int curSum = nums[0];
        int max = curSum;

        for(int i = 1; i < nums.Length; i++) {
            if(curSum < 0) {
                curSum = 0;
            }

            curSum += nums[i];
            max = Math.Max(max, curSum);
        }

        return max;
    }
}