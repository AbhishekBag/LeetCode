public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] arr = new int[m + n];
        int p = 0, q = 0;

        for(int i = 0; i < m + n; i++) {
            if(p >= m) {
                arr[i] = nums2[q++];
            } else if(q >= n) {
                arr[i] = nums1[p++];
            } else if(nums1[p] < nums2[q]) {
                arr[i] = nums1[p++];
            } else {
                arr[i] = nums2[q++];
            }
        }

        for(int i = 0; i < m + n; i++) {
            nums1[i] = arr[i];
        }
    }
}