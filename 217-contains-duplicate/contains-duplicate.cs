public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int , int> map = new Dictionary<int, int>();

        foreach(int item in nums) {
            if(map.ContainsKey(item)) {
                return true;
            }

            map[item] = 1;
        }

        return false;
    }
}