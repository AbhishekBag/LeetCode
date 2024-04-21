public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if (n <= 1) {
            return n;
        }

        int i = 0;
        for (int j = 1; j < n; j++) {
            if (nums[i] != nums[j]) {
                if (j - i > 1) {
                    nums[i + 1] = nums[j];
                }
                i++;
            }
        }

        return i + 1;
    }
}