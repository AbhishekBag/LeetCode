public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length) {
            return string.Empty;
        }

        int i = 0, j = 0, startPtr = 0;
        int res = Int32.MaxValue;;
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        Dictionary<char, int> tMap = GetFrequencyMap(t);
        while (i < s.Length - t.Length + 1)
        {
            if(ValidateMaps(tMap, sMap))
            {
                if (res > j - i)
                {
                    res = j - i;
                    startPtr = i;
                }
                RemoveFromMap(sMap, s[i++]);
            } else if(j < s.Length)
            {
                AddToMap(sMap, s[j++]);
            } else
            {
                break;
            }
        }

        return res > s.Length ? string.Empty : s.Substring(startPtr, res);
    }

    private void AddToMap(Dictionary<char, int> map, char c) {
        if(!map.ContainsKey(c)) {
            map[c] = 0;
        }

        map[c] += 1;
    }

    private void RemoveFromMap(Dictionary<char, int> map, char c) {
        if(map.ContainsKey(c)) {
            if(map[c] == 1) {
                map.Remove(c);
            } else {
                map[c] -= 1;
            }
        }
    }

    private bool ValidateMaps(Dictionary<char, int> tmap, Dictionary<char, int> smap) {
        if(tmap.Count > smap.Count) {
            return false;
        }

        foreach(var item in tmap) {
            if(!smap.ContainsKey(item.Key) || item.Value > smap[item.Key]) {
                return false;
            }
        }

        return true;
    }

    private Dictionary<char, int> GetFrequencyMap(string str) {
        Dictionary<char, int> collection = new Dictionary<char, int>();
        foreach(char c in str) {
            if(!collection.ContainsKey(c)) {
                collection[c] = 0;
            }

            collection[c] += 1;
        }

        return collection;
    }
}