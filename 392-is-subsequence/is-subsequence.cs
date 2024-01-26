public class Solution {
    int[][] arr;
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) {
            return true;
        }

        if(t.Length == 0) {
            return false;
        }

        arr = new int[s.Length][];
        for(int i = 0; i < s.Length; i++) {
            arr[i] = Enumerable.Repeat(-1, t.Length).ToArray();
        }

        return IsSubsequenceHelper(arr, s, t, 0, 0) == 1 ? true : false;

        // return arr[s.Length - 1][t.Length - 1] == 1 ? true : false;
    }

    private int IsSubsequenceHelper(int[][] arr, string s, string t, int p1, int p2) {
        if(p1 >= s.Length) {
            return 1;
        }

        if(p2 >= t.Length) {
            return 0;
        }

        if(arr[p1][p2] != -1) {
            return arr[p1][p2];
        }

        if(s[p1] == t[p2]) {
            int choseChar = IsSubsequenceHelper(arr, s, t, p1 + 1, p2 + 1);
            int dontChoseChar = IsSubsequenceHelper(arr, s, t, p1, p2 + 1);

            arr[p1][p2] = (choseChar == 1 || dontChoseChar == 1) ? 1 : 0;
        } else {
            arr[p1][p2] = IsSubsequenceHelper(arr, s, t, p1, p2 + 1);
        }

        return arr[p1][p2];
    }
}