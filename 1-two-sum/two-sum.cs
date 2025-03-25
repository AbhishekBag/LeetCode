public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        var arr = new int[2];

        for(int i = 0; i < nums.Length; i++) {
            int comp = target - nums[i];
            if(map.ContainsKey(comp)) {
                arr[0] = i;
                arr[1] = map[comp];

                return arr;
            }

            map[nums[i]] = i;
        }

        return arr;
    }
}