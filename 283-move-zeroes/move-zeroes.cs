public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        int i = 0;

        for(; i < n && nums[i] != 0; i++) {
            // if(nums[i] == 0) {
            //     break;
            // }
        }

        for(int j = i + 1; j < n; j++) {
            if(nums[j] != 0) {
                nums[i++] = nums[j];
                nums[j] = 0;
            }
        }
    }
}