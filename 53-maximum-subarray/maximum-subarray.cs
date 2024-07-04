public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int curSum = 0;
        int n = nums.Length;

        for(int i = 0; i < n; i++) {
            max = Math.Max(max, curSum + nums[i]);

            if(curSum + nums[i] > 0) {
                curSum += nums[i];
            } else {
                curSum = 0;
            }
        }

        return max;
    }
}