public class Solution {
    private int[][] memo;
    private Dictionary<(int, int), bool> cache;
    public bool IsMatch(string s, string p) {
        int n = s.Length;
        int m = p.Length;
        cache = new Dictionary<(int, int), bool>();
        memo = new int[n][];
        for(int i = 0; i < n; i++) {
            memo[i] = Enumerable.Repeat(-1, m).ToArray();
        }

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

        // if(memo[i][j] != -1) {
        //     return memo[i][j] == 1;
        // }

        bool match = (i < n && (s[i] == p[j] || p[j] == '.'));
        if(j + 1 < m && p[j + 1] == '*') {
            cache[(i, j)] = MatchString(s, p, i, j + 2) || (match && MatchString(s, p, i + 1, j));
            // memo[i][j] = res1 ? 1 : 0;
            return cache[(i, j)];
        }

        if(match) {
            cache[(i, j)] = MatchString(s, p, i + 1, j + 1);
            // memo[i][j] = res2 ? 1 : 0;
            return cache[(i, j)];
        }

        // memo[i][j] = 0;

        // return memo[i][j] == 1;
        cache[(i, j)] = false;
        return cache[(i, j)];
    }
}