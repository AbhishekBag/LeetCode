public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        if(k == 0) {
            return;
        }

        int[] arr = new int[n];
        for(int i = 0; i < n; i++) {
            int j = (i + k) % n;
            arr[j] = nums[i];
        }

        for(int i = 0; i < n; i++) {
            nums[i] = arr[i];
        }
    }
}
/*
0 1 2 3 4 5 6
1,2,3,4,5,6,7
5,6,7, , , ,4
*/