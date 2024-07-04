public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int curSum = 0;
        int n = nums.Length;

        for(int i = 0; i < n; i++) {
            int item = nums[i];
            max = Math.Max(max, curSum + item);

            if(curSum + item > 0) {
                curSum += item;
            } else {
                curSum = 0;
            }
        }

        return max;
    }
}