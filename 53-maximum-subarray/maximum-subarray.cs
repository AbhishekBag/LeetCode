public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        if(n <= 1) {
            return nums[0];
        }

        int max = Int32.MinValue, sum = 0;

        foreach(int item in nums) {
            if(sum < 0) {
                sum = 0;
            }

            sum += item;
            max = Math.Max(max, sum);
        }

        return max;
    }
}

/*
-2,1,-3,4,-1,2,1,-5,4
sum = -2




*/