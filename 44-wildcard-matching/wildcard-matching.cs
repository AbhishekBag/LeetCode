public class Solution {
    private Dictionary<(int, int), bool> cache;
    public bool IsMatch(string s, string p) {
        cache = new Dictionary<(int, int), bool>();
        return IsMatching(s, p, 0, 0);
    }

    private bool IsMatching(string s, string p, int i, int j) {
        int n = s.Length;
        int m = p.Length;

        if(cache.ContainsKey((i, j))) {
            return cache[(i, j)];
        }

        if(i >= n && j >= m) {
            return true;
        }

        if(j >= m) {
            return false;
        }

        if(p[j] == '*') {
            cache[(i, j)] = IsMatching(s, p, i, j + 1) || i < n && IsMatching(s, p, i + 1, j);
            return cache[(i, j)];
        }        

        if (i < n && (s[i] == p[j] || p[j] == '?')) {
            cache[(i, j)] = IsMatching(s, p, i + 1, j + 1);
            return cache[(i, j)];
        }

        cache[(i, j)] = false;
        return cache[(i, j)];
    }
}