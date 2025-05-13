public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> collection = new();

        foreach(var str in strs) {
            var arr = str.ToArray();
            Array.Sort(arr);
            string k = new string(arr);

            if(!collection.ContainsKey(k)) {
                collection[k] = new List<string>();
            }

            collection[k].Add(str);
        }

        foreach(var item in collection) {
            res.Add(item.Value);
        }

        return res;
    }
}