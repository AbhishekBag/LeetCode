public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] arr = new int[m + n];
        int p = 0;
        int i = 0, j = 0;

        while(i < m && j < n) {
            if(nums1[i] > nums2[j]) {
                arr[p++] = nums2[j++];
            } else {
                arr[p++] = nums1[i++];
            }
        }

        while(i < m) {
            arr[p++] = nums1[i++];
        }

        while(j < n) {
            arr[p++] = nums2[j++];
        }

        for(i = 0; i < m + n; i++) {
            nums1[i] = arr[i];
        }
    }
}