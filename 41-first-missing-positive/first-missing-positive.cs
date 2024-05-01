public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums.Length == 1 && nums[0] == 1) {
            return 2;
        }

        int[] arr = new int[100001];

        int i = 0;
        for(; i < nums.Length; i++) {
            if(nums[i] > 0 && nums[i] < 100001) {
                // Console.WriteLine($"Processing i: {i}, nums[i]: {nums[i]}");
                arr[nums[i]] = nums[i];
            }                
        }

        for(i = 1; i <= 100000; i++) {
            // Console.WriteLine($"i: {i}, arr[i]: {arr[i]}");
            if(arr[i] == 0) {
                // Console.WriteLine($"Returning i: {i}");
                return i;
            }
        }

        return nums.Length + 1;
    }
}