public class Solution {
    public int LengthOfLIS(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        map[nums.Length - 1] = 1;
        for(int i = nums.Length - 2; i >= 0; i--) {
            var val = FindMaxMatchingValue(nums, map, nums[i]);
            map[i] = val + 1;
        }

        int max = 0;
        foreach(var val in map.Values) {
            max = Math.Max(max, val);
        }

        return max;
    }

    private int FindMaxMatchingValue(int[] nums, Dictionary<int, int> map, int num) {
        int max = 0;
        foreach(var item in map) {
            if(num < nums[item.Key]) {
                max = Math.Max(max, item.Value);
            }
        }

        return max;
    }
}