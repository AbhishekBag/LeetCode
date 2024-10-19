public class RandomizedSet {
    public Dictionary<int, int> map;
    public List<int> items;

    public RandomizedSet() {
        map = new Dictionary<int, int>();
        items = new List<int>();
    }
    
    public bool Insert(int val) {
        if(map.ContainsKey(val)) {
            return false;
        }

        map[val] = items.Count();
        items.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!map.ContainsKey(val)) {
            return false;
        }

        var index = map[val];
        var lastElement = items[items.Count - 1];

        items[index] = lastElement;
        map[lastElement] = index;

        map.Remove(val);
        items.RemoveAt(items.Count - 1);

        return true;
    }
    
    public int GetRandom() {
        var rand = new Random();
        return items[rand.Next(0, items.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */