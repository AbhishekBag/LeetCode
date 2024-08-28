public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] preMul = new int[n];
        int[] postMul = new int[n];

        preMul[0] = 1;
        postMul[n - 1] = 1;

        for(int i = 1; i < n; i++) {
            preMul[i] = preMul[i - 1] * nums[i - 1];
        }
        for(int i = n - 2; i >= 0; i--) {
            postMul[i] = postMul[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < n; i++) {
            nums[i] = preMul[i] * postMul[i];
        }

        return nums;
    }
}