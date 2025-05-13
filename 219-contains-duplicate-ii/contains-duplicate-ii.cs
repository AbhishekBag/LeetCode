public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> collection = new();
        for(int i = 0; i < nums.Length; i++) {
            int cur = nums[i];
            if(!collection.ContainsKey(cur)) {
                collection[cur] = i;
            } else {
                if(Math.Abs(i - collection[cur]) <= k) {
                    return true;
                } else {
                    collection[cur] = i;
                }
            }
        }

        return false;
    }
}