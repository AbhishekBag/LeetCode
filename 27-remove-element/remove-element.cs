public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) {
            return 0;
        }

        if(nums.Length == 1 && nums[0] == val) {
            return 0;
        }

        if(nums.Length == 1 && nums[0] != val) {
            return 1;
        }

        int pos = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == val) {
                pos = i;
                break;
            }

            if(i == nums.Length - 1) {
                return nums.Length;
            }
        }

        for(int i = pos + 1; i < nums.Length; i++) {
            if(nums[i] != val) {
                nums[pos++] = nums[i];
            }
        }

        return pos;
    }
}