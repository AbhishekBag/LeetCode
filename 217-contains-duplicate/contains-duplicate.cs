public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> collection = new();

        foreach(int num in nums) {
            if(collection.Contains(num)) 
            {
                return true;
            } else {
                collection.Add(num);
            }
        }

        return false;
    }
}