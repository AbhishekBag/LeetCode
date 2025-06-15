public class Solution {
    private int[] memo;
    public int Rob(int[] nums) {
        memo = Enumerable.Repeat(Int32.MinValue, nums.Length).ToArray();
        return GetSum(nums, 0);
    }

    private int GetSum(int[] nums, int index) {
        if(index >= nums.Length) {
            return 0;
        }

        if(memo[index] != Int32.MinValue) {
            return memo[index];
        }
        
        memo[index] = Math.Max(nums[index] + GetSum(nums, index + 2), GetSum(nums, index + 1));

        return memo[index];
    }
}