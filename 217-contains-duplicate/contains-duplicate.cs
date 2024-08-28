public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums.Length <= 1) {
            return false;
        }

        HashSet<int> collection = new HashSet<int>();
        foreach(int item in nums) {
            if(collection.Contains(item)) {
                return true;
            }

            collection.Add(item);
        }

        return false;
    }
}