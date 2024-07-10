public class Solution {
    public bool Check(int[] nums) {
        int count = 0, max = Int32.MinValue;

        for(int i = 1; i < nums.Length; i++) {
            if(count > 1) {
                return false;
            }

            if(nums[i] < nums[i - 1]) {
                count++;
            }
        }

        if(nums[ nums.Length - 1] > nums[0]) {
            count++;
        }

        return count <= 1 ? true : false;;
    }
}