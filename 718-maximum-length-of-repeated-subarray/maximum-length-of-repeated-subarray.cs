public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int maxLength = 0;
        int N = nums1.Length;
        int M = nums2.Length;
        int[][] dp = new int[N + 1][];

        for(int i = 0; i < N + 1; i++) {
            dp[i] = Enumerable.Repeat(0, M + 1).ToArray();
        }

        for(int i = 1; i <= N; i++) {
            for(int j = 1; j <= M; j++) {
                // Console.WriteLine($"N: {N}; M: {M}; i: {i}; j: {j}; nums1[i - 1]: {nums1[i - 1]}; nums2[j - 1]: {nums2[j - 1]}; maxLength: {maxLength}");

                if(nums1[i - 1] == nums2[j - 1]) {
                    // Console.WriteLine($"{i} and {j} matched");
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                    maxLength = Math.Max(maxLength, dp[i][j]);
                }
            }
        }

        return maxLength;
    }
}