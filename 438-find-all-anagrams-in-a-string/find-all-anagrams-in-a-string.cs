public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        List<int> res = new List<int>();

        pMap = GetCharCount(p);
        int j = 0, i = 0;
        for(; j < s.Length; j++) {
            char c = s[j];

            if(sMap.ContainsKey(c)) {
                sMap[c]++;
            } else {
                sMap[c] = 1;
            }

            if(j > p.Length - 1) {
                char iC = s[i++];
                if(sMap.ContainsKey(iC) && sMap[iC] == 1) {
                    sMap.Remove(iC);
                } else {
                    sMap[iC]--;
                }
            }

            if(j >= p.Length - 1) {
                if(IsAnagram(pMap, sMap)) {
                    res.Add(i);
                }
            }
        }

        return res;
    }

    public bool IsAnagram(Dictionary<char, int> pMap, Dictionary<char, int> sMap) {
        foreach(var item in pMap) {
            if(!sMap.ContainsKey(item.Key) || item.Value != sMap[item.Key]) {
                return false;
            }
        }

        return true;
    }

    public Dictionary<char, int> GetCharCount(string str) {
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        foreach(char c in str) {
            if(pMap.ContainsKey(c)) {
                pMap[c]++;
            } else {
                pMap[c] = 1;
            }
        }

        return pMap;
    }
}