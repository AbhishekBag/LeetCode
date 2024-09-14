public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> collections = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            var strArr = str.ToArray();
            Array.Sort(strArr);
            var sortedStr = new string(strArr);

            if(!collections.ContainsKey(sortedStr)) {
                collections[sortedStr] = new List<string>();
            }

            collections[sortedStr].Add(str);
        }

        return collections.Values.ToList<IList<string>>();
    }
}