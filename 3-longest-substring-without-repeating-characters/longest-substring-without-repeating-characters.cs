public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        if(n <= 1) {
            return n;
        }

        Dictionary<char, int> map = new Dictionary<char, int>();
        int i = 0, maxL = 1;
        map.Add(s[i], 1);
        for(int j = i + 1; j < n;) {
            char c = s[j];
            if(map.ContainsKey(c)) {
                map.Remove(s[i]);
                i++;
            } else {
                map[c] = 1;
                maxL = Math.Max(maxL, j - i + 1);
                j++;
            }
        }

        return maxL;
    }
}