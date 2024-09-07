public class Solution {
    private int[] arr;
    public int NumDecodings(string s) {
        arr = Enumerable.Repeat(-1, s.Length).ToArray();
        return CountWays(s, 0);
    }

    private int CountWays(string s, int i) {
        if(i == s.Length) {
            return 1;
        }
        if(i >= s.Length || s[i] == '0') {
            return 0;
        }

        if(arr[i] != -1) {
            return arr[i];
        }

        if(i < s.Length - 1 && (s[i] == '1' || (s[i] == '2' && s[i + 1] - '0' <= 6))) {
            arr[i] = CountWays(s, i + 1) + CountWays(s, i + 2);
        } else {
            arr[i] = CountWays(s, i + 1);
        }

        return arr[i];
    }
}

/*
226 (i)

if(s[i] == 0) {
    return 0;
}

if(i == s.Length - 1) {
    return 1;
}

if(s[i] == 1 || s[i] == 2 && i < s.Length && s[i + 1] <= 6) {
    count = f(s, i + 1) + f(s, i + 2)
} else {
    count = f(s, i + 1)
}
*/