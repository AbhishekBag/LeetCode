public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Stack<int> stk = new ();
        Dictionary<int, int> map = new ();
        int[] arr = new int[10001];
        int[] res = new int[nums1.Length];

        for(int i = 0; i < nums2.Length; i++) {
            while(stk.Count() != 0 && stk.Peek() < nums2[i]) {
                var poped = stk.Pop();
                // map[poped] = nums2[i];
                arr[poped] = nums2[i];
            }

            stk.Push(nums2[i]);
        }

        // for(int i = 0; i < nums1.Length; i++) {
        //     if(map.ContainsKey(nums1[i])) {
        //         res[i] = map[nums1[i]];
        //     } else {
        //         res[i] = -1;
        //     }
        // }

        for(int i = 0; i < nums1.Length; i++) {
            if(arr[nums1[i]] != 0) {
                res[i] = arr[nums1[i]];
            } else {
                res[i] = -1;
            }
        }

        return res;
    }
}