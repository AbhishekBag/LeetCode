public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int i = 0, j = 0;
        int sum = 0, n = nums.Length;
        int len = Int32.MaxValue;

        while(i < n && j < n) {
            sum += nums[j];
            while(sum >= target) {
                len = Math.Min(len, j - i + 1);
                sum -= nums[i++];
            }

            j++;
        }

        return len == Int32.MaxValue ? 0 : len;
    }
}