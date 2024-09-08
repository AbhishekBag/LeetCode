public class Solution {
    public bool CanJump(int[] nums) {
        bool[] arr = new bool[nums.Length];
        arr[nums.Length - 1] = true;

        for(int i = nums.Length - 2; i >= 0; i--) {
            arr[i] = IsPossible(arr, i, nums[i]);
        }

        return arr[0];
    }

    private bool IsPossible(bool[] arr, int pos, int maxJump) {
        int n = arr.Length;
        for(int i = pos + maxJump; i >= pos; i--) {
            if(i >= n || arr[i]) {
                return true;
            }
        }

        return false;
    }
}