public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new ();
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++) {
            int comp = target - nums[i];

            if(map.ContainsKey(comp)) {
                res[0] = i;
                res[1] = map[comp];

                break;
            } else {
                map[nums[i]] = i;
            }
        }

        return res;
    }
}