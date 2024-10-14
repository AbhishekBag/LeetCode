public class Solution {
    public bool CanJump(int[] nums) {
        int lastGoodSpot = nums.Length - 1;

        for(int i = nums.Length - 2; i >= 0; i--) {
            if(nums[i] + i >= lastGoodSpot) {
                lastGoodSpot = i;
            }
        }

        return lastGoodSpot == 0;
    }
}