public class Solution {
    public IList<int> FindAnagrams(string s, string p) {        
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        List<int> res = new List<int>();

        if(s.Length < p.Length) {
            return res;
        }
        
        pMap = FindCharMap(p, p.Length);
        sMap = FindCharMap(s, p.Length);

        if(IsAnagram(pMap, sMap)) {
            res.Add(0);
        }

        for(int i = p.Length; i < s.Length; i++) {
            char c = s[i];
            if(sMap.ContainsKey(c)) {
                sMap[c]++;
            } else {
                sMap[c] = 1;
            }

            char cPrev = s[i - p.Length];
            if(sMap.ContainsKey(cPrev) && sMap[cPrev] == 1) {
                sMap.Remove(cPrev);
            } else {
                sMap[cPrev]--;
            }

            if(IsAnagram(pMap, sMap)) {
                res.Add(i - p.Length + 1);
            }
        }

        return res;
    }

    private bool IsAnagram(Dictionary<char, int> pMap, Dictionary<char, int> sMap) {
        foreach(var item in pMap) {
            if(!sMap.ContainsKey(item.Key) || sMap[item.Key] != item.Value) {
                return false;
            }
        }

        return true;
    }

    private Dictionary<char, int> FindCharMap(string str, int l) {
        Dictionary<char, int> cMap = new Dictionary<char, int>();
        for(int i = 0; i < l; i++) {
            char c = str[i];
            if(cMap.ContainsKey(c)) {
                cMap[c]++;
            } else {
                cMap[c] = 1;
            }
        }

        return cMap;
    }
}