public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;
        int n = s.Length;

        for(int i = 0; i < n; i++) {
            int l = i;
            int r = i;

            while(l >= 0 && r < n && s[l] == s[r]) {
                count++;
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while(l >= 0 && r < n && s[l] == s[r]) {
                count++;
                l--;
                r++;
            } 
        }

        return count++;
    }
}