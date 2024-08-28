public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        if(n <= 1) {
            return nums[0];
        }

        int i = 0, j = n - 1;

        while(i < j) {
            int mid = i + (j - i)/2;
            if(nums[mid] < nums[j]) {
                j = mid;
            } if(nums[mid] > nums[j]) {
                i = mid + 1;
            }
        }

        return nums[i];
    }
}

/*
1,2,3,4,5
4,5,1,2,3
*/