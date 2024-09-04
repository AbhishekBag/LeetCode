public class Solution {
    private int[] arr1;
    private int[] arr2;
    public int Rob(int[] nums) {
        if(nums.Length == 1) {
            return nums[0];
        }
        
        arr1 = Enumerable.Repeat(-1, nums.Length).ToArray();
        arr2 = Enumerable.Repeat(-1, nums.Length).ToArray();
        return Math.Max(RobHouse(nums, 0, nums.Length - 2, arr1), RobHouse(nums, 1, nums.Length - 1, arr2));
    }

    private int RobHouse(int[] nums, int i, int end, int[] arr) {
        if(i > end) {
            return 0;
        }

        if(arr[i] != -1) {
            return arr[i];
        }

        int take = nums[i] + RobHouse(nums, i + 2, end, arr);
        int dontTake = RobHouse(nums, i + 1, end, arr);

        arr[i] = Math.Max(take, dontTake);

        return arr[i];
    }
}