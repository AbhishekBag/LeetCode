public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        if(n <= 1) {
            return s;
        }

        var res = s[0].ToString();
        for(int i = 0; i < n; i++) {
            var tmpOdd = GetMaxPalindromicStringCenteredAt(s, i, true);
            var tmpEven = GetMaxPalindromicStringCenteredAt(s, i, false);
            var tmp = tmpOdd.Length > tmpEven.Length ? tmpOdd : tmpEven;

            if(res.Length < tmp.Length) {
                res = tmp;
            }
        }

        return res;
    }

    private string GetMaxPalindromicStringCenteredAt(string s, int center, bool checkOddLengthP) {
        int n = s.Length;
        
        int left = checkOddLengthP ? center - 1 : center;
        int right = center + 1;
        while(left >= 0 && right < n && s[left] == s[right]) {
            left--;
            right++;
        }

        left += 1;
        right -= 1;
        return s.Substring(left, right - left + 1);
    }
}