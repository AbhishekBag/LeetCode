public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;
        int n = s.Length;

        for(int i = 0; i < n; i++) {
            count += CountPalindromicSubstrings(s, i, i, n);
            count += CountPalindromicSubstrings(s, i, i + 1, n);            
        }

        return count++;
    }

    private int CountPalindromicSubstrings(string s, int l, int r, int n) {
        int count = 0;
        while(l >= 0 && r < n && s[l] == s[r]) {
            count++;
            l--;
            r++;
        }

        return count; 
    }
}