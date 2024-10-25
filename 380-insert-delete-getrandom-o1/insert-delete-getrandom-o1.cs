public class RandomizedSet {
    private Dictionary<int, int> map;
    private List<int> arr;
    public RandomizedSet() {
        map = new Dictionary<int, int>();
        arr = new List<int>();
    }
    
    public bool Insert(int val) {
        if(map.ContainsKey(val)) {
            return false;
        }

        map[val] = arr.Count;
        arr.Add(val);

        return true;
    }
    
    public bool Remove(int val) {
        if(!map.ContainsKey(val)) {
            return false;
        }

        int index = map[val];
        int lastItem = arr[arr.Count - 1];

        arr[index] = lastItem;
        arr.RemoveAt(arr.Count - 1);
        map[lastItem] = index;
        map.Remove(val);

        return true;
    }
    
    public int GetRandom() {
        var rand = new Random();
        return arr[rand.Next(arr.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */