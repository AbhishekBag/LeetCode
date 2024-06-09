public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> res = new List<int>();
        if(s.Length < p.Length) {
            return res;
        }

        int[] pMap = new int[26];
        int[] sMap = new int[26];

        for(int i = 0; i < p.Length; i++) {
            pMap[p[i] - 'a']++;
            sMap[s[i] - 'a']++;
        }

        int matches = 0;
        for(int i = 0; i < 26; i++) {
            if(pMap[i] == sMap[i]) {
                matches++;
            }
        }

        if(matches == 26) {
            res.Add(0);
        }

        // Sliding window processing
        for(int i = p.Length; i < s.Length; i++) {
            int r = s[i] - 'a';                 // char coming inside the window
            int l = s[i - p.Length] - 'a';      // char going out of the window

            if(pMap[r] == sMap[r]) {
                matches--;
            }

            sMap[r]++;
            if(pMap[r] == sMap[r]) {
                matches++;
            }

            if(pMap[l] == sMap[l]) {
                matches--;
            }

            sMap[l]--;
            if(pMap[l] == sMap[l]) {
                matches++;
            }

            if(matches == 26) {
                res.Add(i - p.Length + 1);
            }
        }

        return res;
    }
}