public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();

        foreach(int item in nums) {
            if(map.Contains(item)) {
                return true;
            }

            map.Add(item);
        }

        return false;
    }
}