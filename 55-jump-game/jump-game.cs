public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        if(n == 1) {
            return true;
        }

        int lastAdded = n - 1;

        for(int i = n - 2; i >= 0; i--) {
            int jump = i + nums[i];

            if(jump >= lastAdded) {
                lastAdded = i;
            }
        }

        return lastAdded == 0;
    }
}

// n = 5
// 0, 1, 2, 3, 4
// 2, 3, 1, 1, 4