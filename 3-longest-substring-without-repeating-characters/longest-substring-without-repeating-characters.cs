public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) {
            return s.Length;
        }
        
        int i = 0, j = 1, maxLength = 1;
        HashSet<char> map = new HashSet<char>();
        map.Add(s[i]);
        while(j < s.Length) {
            if(map.Contains(s[j])) {
                map.Remove(s[i++]);
            } else {
                map.Add(s[j++]);
                maxLength = Math.Max(maxLength, map.Count);
            }
        }

        return maxLength;
    }
}