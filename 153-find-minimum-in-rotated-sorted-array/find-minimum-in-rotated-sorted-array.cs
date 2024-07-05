public class Solution {
    public int FindMin(int[] nums) {
        int i = 0, j = nums.Length - 1;

        while(i < j) {
            int mid = i + (j - i)/2;
            if(nums[mid] > nums[j]) {
                i = mid + 1;
            } else {
                j = mid;
            }
        }

        return nums[i];
    }
}

/*
0,1,2,4,5,6,7
7,0,1,2,4,5,6

i = 0, j = 7, mid = 3
i = 0, j = 3, mid = 1
i = 0, j = 1, mid = 0
*/