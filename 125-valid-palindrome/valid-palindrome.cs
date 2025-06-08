public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length <= 1) {
            return true;
        }

        int i = 0, j = s.Length - 1;

        while(i <= j) {
            while(i < s.Length && !char.IsLetterOrDigit(s[i])) i++;
            while(j >= 0 && !char.IsLetterOrDigit(s[j])) j--;

            if(i >= s.Length || j < 0) {
                return true;
            }

            // Console.WriteLine($"i: {i}, s[i]: {s[i]}; j: {j}, s[j]: {s[j]}");
            if(i <= j && char.ToUpper(s[i]) != char.ToUpper(s[j])) {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}