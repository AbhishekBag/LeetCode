public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length;
        if(n <= 1) {
            return 1;
        }

        int res = 0;

        for(int i = 0; i < s.Length; i++) {
            var oddPCount = GetPalindromeCount(s, i, true);
            var evenPCount = GetPalindromeCount(s, i, false);

            res += oddPCount + evenPCount;
        }

        return res;
    }

    private int GetPalindromeCount(string s, int center, bool oddP) {
        int n = s.Length;
        int left = oddP ? center - 1 : center;
        int right = center + 1;
        int count = oddP ? 1 : 0;
        while(left >= 0 && right < n && s[left] == s[right]) {
            count++;
            left--;
            right++;
        }

        return count;
    }
}