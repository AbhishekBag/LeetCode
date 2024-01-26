public class Solution {
    public bool IsSubsequence(string s, string t) {
        return IsSubsequenceHelper(s, t, 0, 0);
    }

    private bool IsSubsequenceHelper(string s, string t, int p1, int p2) {
        if(p1 >= s.Length) {
            return true;
        }

        if(p2 >= t.Length) {
            return false;
        }

        if(s[p1] == t[p2]) {
            bool choseChar = IsSubsequenceHelper(s, t, p1 + 1, p2 + 1);
            bool dontChoseChar = IsSubsequenceHelper(s, t, p1, p2 + 1);

            return choseChar || dontChoseChar;
        } else {
            return IsSubsequenceHelper(s, t, p1, p2 + 1);
        }
    }
}