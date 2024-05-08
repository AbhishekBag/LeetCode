public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        prefix[0] = 1;
        suffix[n - 1] = 1;

        for(int i = 1; i < n; i++) {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }
        
        for(int j = n - 2; j >= 0; j--) {
            suffix[j] = suffix[j + 1] * nums[j + 1];
        }

        // int[] res = new int[n];
        for(int i = 0; i < n; i++) {
            prefix[i] = prefix[i] * suffix[i];
        }

        return prefix;
    }
}