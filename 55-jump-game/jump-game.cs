public class Solution {
    public bool CanJump(int[] nums) {
        int lastGoodPosition = nums.Length - 1;

        for(int i = nums.Length - 2; i >= 0; i--) {
            if(i + nums[i] >= lastGoodPosition) {
                lastGoodPosition = i;
            }
        }

        return lastGoodPosition == 0;
    }
}