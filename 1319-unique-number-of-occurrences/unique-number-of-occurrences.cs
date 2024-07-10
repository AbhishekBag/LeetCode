public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int , int> map = new Dictionary<int, int>();
        HashSet<int> set = new HashSet<int>();

        foreach(int item in arr) {
            if(!map.ContainsKey(item)) {
                map[item] = 1;
            } else {
                map[item]++;
            }
        }

        foreach(var item in map) {
            if(set.Contains(item.Value)) {
                return false;
            }

            set.Add(item.Value);
        }

        return true;
    }
}