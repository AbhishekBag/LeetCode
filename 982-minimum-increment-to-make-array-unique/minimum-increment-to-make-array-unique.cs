public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int count = 0;

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] == nums[i - 1]) {
                nums[i]++;
                count++;
            } else if(nums[i] < nums[i - 1]) {
                count += nums[i - 1] - nums[i] + 1;
                nums[i] = nums[i - 1] + 1;
            }
        }

        return count;
    }
}