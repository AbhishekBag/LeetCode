public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);

            if(map.ContainsKey(sortedStr)) {
                map[sortedStr].Add(str);
            } else {
                map[sortedStr] = new List<string>() { str };
            }
        }

        return map.Values.ToList<IList<string>>();
    }
}