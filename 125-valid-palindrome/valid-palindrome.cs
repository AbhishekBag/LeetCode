public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length <= 0) {
            return true;
        }

        s = CleanString(s.ToLower());
        // Console.WriteLine($"after cleanup: s: {s}");
        int n = s.Length;
        for(int i = 0; i < n / 2; i++) {
            if(s[i] != s[n - i - 1]) {
                // Console.WriteLine($"not equal; i: {i}; s[i]: {s[i]}, s[n - i - 1]: {s[n - i - 1]}");
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