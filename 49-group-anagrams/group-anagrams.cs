public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);

            // Console.WriteLine($"actual: {str}, sorted: {sortedStr}");
            if(map.ContainsKey(sortedStr)) {
                map[sortedStr].Add(str);
            } else {
                map[sortedStr] = new List<string>() { str };
            }
        }

        foreach(var item in map) {
            res.Add(item.Value);
        }

        return res;
    }
}