public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int sum = 0;
        int[] left = new int[n];

        int max = Int32.MinValue;
        for(int i = 0; i < n; i++) {
            max = Math.Max(max, height[i]);
            left[i] = max;
        }

        max = Int32.MinValue;
        for(int i = n - 1; i >= 0; i--) {
            max = Math.Max(max, height[i]);
            sum += Math.Min(left[i], max) - height[i];
        }

        return sum;
    }
}