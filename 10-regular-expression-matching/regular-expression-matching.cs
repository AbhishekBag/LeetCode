public class Solution {
    private Dictionary<(int, int), bool> cache;
    public bool IsMatch(string s, string p) {
        int n = s.Length;
        int m = p.Length;
        cache = new Dictionary<(int, int), bool>();
        
        return MatchString(s, p, 0, 0);
    }

    private bool MatchString(string s, string p, int i, int j) {
        if(cache.ContainsKey((i, j))) {
            return cache[(i, j)];
        }
        int n = s.Length;
        int m = p.Length;
        if(i >= n && j >= m) {
            return true;
        }

        if(j >= m) {
            return false;
        }

        bool match = (i < n && (s[i] == p[j] || p[j] == '.'));
        if(j + 1 < m && p[j + 1] == '*') {
            cache[(i, j)] = MatchString(s, p, i, j + 2) || (match && MatchString(s, p, i + 1, j));
            return cache[(i, j)];
        }

        if(match) {
            cache[(i, j)] = MatchString(s, p, i + 1, j + 1);
            return cache[(i, j)];
        }

        cache[(i, j)] = false;
        return cache[(i, j)];
    }
}