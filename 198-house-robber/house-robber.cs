public class Solution {
    private int[] arr;
    public int Rob(int[] nums) {
        arr = Enumerable.Repeat(-1, nums.Length).ToArray();
        return RobHouse(nums, 0);
    }

    private int RobHouse(int[] nums, int i) {
        if(i >= nums.Length) {
            return 0;
        }

        if(arr[i] != -1) {
            return arr[i];
        }

        int pick = nums[i] + RobHouse(nums, i + 2);
        int notPick = RobHouse(nums, i + 1);

        arr[i] = Math.Max(pick, notPick);
        return arr[i];
    }
}