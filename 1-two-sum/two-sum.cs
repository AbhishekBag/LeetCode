public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        Dictionary<int, int> map = new();

        for(int i = 0; i < nums.Length; i++) {
            int c = target - nums[i];
            if(!map.ContainsKey(c)) {
                map[nums[i]] = i;
            } else {
                res[0] = i;
                res[1] = map[c];
            }
        }

        return res;
    }
}