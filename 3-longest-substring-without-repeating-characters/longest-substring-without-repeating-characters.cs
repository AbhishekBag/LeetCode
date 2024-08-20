public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) {
        return s.Length;
        }

        int res = 0;
        HashSet<char> set = new HashSet<char>();
        int i = 0, j = 0;
        set.Add(s[j++]);

        while(j < s.Length) {
            if(set.Contains(s[j])) {
                set.Remove(s[i++]);
            } else {
                set.Add(s[j++]);
                res = Math.Max(res, set.Count());
            }
        }

        return res;
    }
}