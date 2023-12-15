public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> res = new List<int>();

        for(int i = 0; i < nums.Length; i++) {
            int comp = target - nums[i];
            if(map.ContainsKey(comp)) {
                res.Add(i);
                res.Add(map[comp]);

                break;
            } else {
                if(!map.ContainsKey(nums[i])) {
                    map.Add(nums[i], i);
                }                
            }
        }

        return res.ToArray();
    }
}