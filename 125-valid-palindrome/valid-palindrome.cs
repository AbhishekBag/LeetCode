public class Solution {
    public bool IsPalindrome(string s) {
        s = CleanString(s);
        int n = s.Length;

        for(int i = 0; i < n/2; i++) {
            if(s[i] != s[n - i - 1]) {
                return false;
            }
        }

        return true;
    }

    private string CleanString(string str) {
        var sb = new StringBuilder();
        foreach(char c in str) {
            if(Char.IsLetterOrDigit(c)) {
                sb.Append(Char.ToLower(c));
            }
        }

        return sb.ToString();
    }
}