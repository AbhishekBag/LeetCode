public class Solution {
    public bool IsMatch(string s, string p) {
        return MatchString(s, p, 0, 0);
    }

    private bool MatchString(string s, string p, int i, int j) {
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
            return MatchString(s, p, i, j + 2) || (match && MatchString(s, p, i + 1, j));
        }

        if(match) {
            return MatchString(s, p, i + 1, j + 1);
        }

        return false;
    }
}