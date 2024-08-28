public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        if(n <= 1) {
            return nums[n - 1] == target ? n - 1 : -1;
        }

        int minPivot = GetMinPivot(nums);
        int leftSearch = BinarySearch(nums, 0, minPivot - 1, target);
        int rightSearch = BinarySearch(nums, minPivot, n - 1, target);

        return leftSearch == -1 ? rightSearch : leftSearch;
    }

    private int BinarySearch(int[] nums, int start, int end, int target) {
        int n = nums.Length;
        if(start >= n || end < 0) {
            return -1;
        }
        if(start == end && nums[start] == target) {
            return start;
        }

        int i = start, j = end;
        while(i <= j) {
            int mid = i + (j - i)/2;
            if(nums[mid] == target) {
                return mid;
            } else if(nums[mid] < target) {
                i = mid + 1;
            } else {
                j = mid - 1;
            }
        }

        return -1;
    }

    private int GetMinPivot(int[] nums) {
        int n = nums.Length;

        if(n <= 1) {
            return 0;
        }

        int i = 0, j = n - 1;
        while(i < j) {
            int mid = i + (j - i)/2;
            if(nums[mid] < nums[j]) {
                j = mid;
            } else if (nums[mid] > nums[j]) {
                i = mid + 1;
            }
        }

        return i;
    }
}