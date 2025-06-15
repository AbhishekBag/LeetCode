public class Solution {
    private int[] memo1, memo2;
    public int Rob(int[] nums) {
        if(nums.Length == 1) {
            return nums[0];
        }
        
        memo1 = Enumerable.Repeat(-1, nums.Length).ToArray();
        memo2 = Enumerable.Repeat(-1, nums.Length).ToArray();
        
        return Math.Max(CollectBounty(nums, 0, nums.Length - 2, 0, memo1), CollectBounty(nums, 1, nums.Length - 1, 1, memo2));
    }

    private int CollectBounty(int[] nums, int start, int end, int index, int[] memo) {
        if(index < start || index > end) {
            return 0;
        }

        if(memo[index] != -1) {
            return memo[index];
        }

        memo[index] = Math.Max(nums[index] + CollectBounty(nums, start, end, index + 2, memo), CollectBounty(nums, start, end, index + 1, memo));

        return memo[index];
    }
}