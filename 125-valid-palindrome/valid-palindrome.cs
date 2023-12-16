public class Solution {
    public bool IsPalindrome(string s) {
        s = CleanString(s.ToLower());
        int n = s.Length;
        
        if(n <= 0) {
            return true;
        }

        for(int i = 0; i < n / 2; i++) {
            if(s[i] != s[n - i - 1]) {
                return false;
            }
        }

        return true;
    }

    private string CleanString(string s) {
        StringBuilder sb = new StringBuilder();
        foreach(char c in s) {
            if(Char.IsLetterOrDigit(c)) {// c >= 'a' && c <= 'z' || c >= '0' && c <= '9') {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}