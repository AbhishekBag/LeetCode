public class Solution {
    public bool IsAnagram(string s, string t) {
        var sMap = GetMap(s);

        foreach(char c in t) {
            if(!sMap.ContainsKey(c)) {
                return false;
            } else {
                if(sMap[c] == 1) {
                    sMap.Remove(c);
                } else {
                    sMap[c]--;
                }
            }
        }

        if(sMap.Count() == 0) {
            return true;
        }

        return false;
    }

    private Dictionary<char, int> GetMap(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char c in s) {
            if(map.ContainsKey(c)) {
                map[c]++;
            } else {
                map.Add(c, 1);
            }
        }

        return map;
    }
}