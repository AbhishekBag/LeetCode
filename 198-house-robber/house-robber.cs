public class Solution {
    public int Rob(int[] nums) {
        int[] arr = Enumerable.Repeat(-1, nums.Length).ToArray();
        return FindSum(nums, 0, arr);
    }

    private int FindSum(int[] nums, int curr, int[] arr) {
        if(curr >= nums.Length) {
            return 0;
        }

        if(arr[curr] != -1) {
            return arr[curr];
        }

        var choseCurr = nums[curr] + FindSum(nums, curr + 2, arr);
        var notChoseCurr = FindSum(nums, curr + 1, arr);

        arr[curr] = Math.Max(choseCurr, notChoseCurr);

        return arr[curr];
    }
}