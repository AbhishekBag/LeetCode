public class Solution {
    public bool IsAdditiveNumber(string num) {
        int n = num.Length;
        
        for(int i = 1; i <= (n - 1)/2; i++) {
            for(int j = 1; j <= (n - 1)/2; j++) {
                if(IsValidString(num, i, j, 0)) {
                    return true;
                }
            }
        }

        return false;
    }

    // 112358
    // 1  1
    // 1 1 
    private bool IsValidString(string num, int i, int j, int init) {
        int n = num.Length;

        if (init + i + j == n) {
            return true;
        }

        if (init + i >= n || init + i + j >= n) {
            return false;
        }

        var str1 = num.Substring(init, i);
        var str2 = num.Substring(init + i, j);

        if((str1.Length > 1 && str1.StartsWith('0')) || (str2.Length > 1 && str2.StartsWith('0'))) {
            return false;
        }

        if (!Int64.TryParse(str1, out var n1)) {
            return false;
        }

        if (!Int64.TryParse(str2, out var n2)) {
            return false;
        }

        var sum = n1 + n2;
        var sStr = sum.ToString();
        var jStr = num.Substring(init + i + j);

        if (!jStr.StartsWith(sStr)) {
            return false;
        }

        return IsValidString(num, j, sStr.Length, init + i);
    }
}