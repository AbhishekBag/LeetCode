public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] maxLeft = new int[n];
        int[] maxRight = new int[n];

        int maxTill = 0;
        for(int i = 0; i < n; i++) {
            maxTill = Math.Max(maxTill, height[i]);
            maxLeft[i] = maxTill;
        }

        maxTill = 0;
        for(int j = n - 1; j >= 0; j--) {
            maxTill = Math.Max(maxTill, height[j]);
            maxRight[j] = maxTill;
        }

        int sum = 0;
        for(int i = 0; i < n; i++) {
            sum += Math.Min(maxLeft[i], maxRight[i]) - height[i];
        }

        return sum;
    }
}