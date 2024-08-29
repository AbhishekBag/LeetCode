public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long res = 0;
        int badIndex = -1;
        int minIndex = -1;
        int maxIndex = -1;

        for(int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if(num < minK || num > maxK) {
                badIndex = i;
            }

            if(num == minK) {
                minIndex = i;
            }

            if(num == maxK) {
                maxIndex = i;
            }

            res += Math.Max(0, Math.Min(minIndex, maxIndex) - badIndex);
        }

        return res;
    }
}