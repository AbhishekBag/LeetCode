public class Solution {
    public int Search(int[] nums, int target) {
        int pivot = GetPivot(nums);

        // Console.WriteLine($"pivot: {pivot}");

        int leftSearch = Find(nums, target, 0, pivot - 1);
        int rightSearch = Find(nums, target, pivot, nums.Length - 1);

        return leftSearch == -1 ? rightSearch : leftSearch;
    }

    private int GetPivot(int[] nums) {
        int i = 0, j = nums.Length - 1;

        while(i <= j) {
            int mid = i + (j - i)/2;
            if(nums[nums.Length - 1] < nums[mid]) {
                i = mid + 1;
            } else {
                j = mid - 1;
            }
        }

        return i;
    }

    private int Find(int[] nums, int target, int start, int end) {
        while(start <= end) {
            int mid = start + (end - start)/2;
            // Console.WriteLine($"Searching for: {target}, start: {start}, end: {end}, mid: {mid}");
            if(nums[mid] == target) {
                return mid;
            }

            if(nums[mid] < target) {
                start = mid + 1;
            } else {
                end = mid - 1;
            }
        }

        return -1;
    }
}