public class Solution {
    public bool CanJump(int[] nums) {
        HashSet<int> possible = new HashSet<int>();
        int n = nums.Length;
        if(n == 1) {
            return true;
        }

        possible.Add(n-1);

        for(int i = n - 2; i >= 0; i--) {
            for(int j = nums[i]; j > 0; j--) {
                int jump = i + j;
                if(possible.Contains(jump) || jump >= n) {
                    possible.Add(i);
                    break;
                }
            }
        }

        return possible.Contains(0);
    }
}

// n = 5
// 0, 1, 2, 3, 4
// 2, 3, 1, 1, 4