public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] arr = Enumerable.Repeat(1, n).ToArray();

        for(int i = n - 2; i >= 0; i--) {
            int curMax = nums[i];
            for(int j = i + 1; j < n; j++) {
                if(nums[i] < nums[j]) {
                    arr[i] = Math.Max(arr[i], arr[j] + 1);
                }
            }
        }

        int max = 0;
        for(int i = 0; i < arr.Length; i++) {
            max = Math.Max(max, arr[i]);
        }

        // Print(arr);

        return max;
    }

    private void Print(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            Console.Write($"{arr[i]}, ");
        }

        Console.WriteLine();
    }
}