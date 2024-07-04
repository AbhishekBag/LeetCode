public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int curSum = 0;

        foreach(int num in nums) {
            max = Math.Max(max, curSum + num);

            if(curSum + num > 0) {
                curSum += num;
            } else {
                curSum = 0;
            }
        }

        return max;
    }
}