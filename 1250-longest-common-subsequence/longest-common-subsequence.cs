public class Solution {
    int[][] arr;
    public int LongestCommonSubsequence(string text1, string text2) {
        arr = new int[text1.Length][];
        for(int i = 0; i < text1.Length; i++) {
            arr[i] = Enumerable.Repeat(-1, text2.Length).ToArray();
        }

        return GetSequenceLength(text1, text2, 0, 0);
    }

    private int GetSequenceLength(string text1, string text2, int p1, int p2) {
        if(p1 >= text1.Length || p2 >= text2.Length) {
            return 0;
        }

        if(arr[p1][p2] != -1) {
            return arr[p1][p2];
        }

        if(text1[p1] != text2[p2]) {
            int IncreaseT1 = GetSequenceLength(text1, text2, p1 + 1, p2);
            int IncreaseT2 = GetSequenceLength(text1, text2, p1, p2 + 1);

            arr[p1][p2] = Math.Max(IncreaseT1, IncreaseT2);
        } else {
            arr[p1][p2] = 1 + GetSequenceLength(text1, text2, p1 + 1, p2 + 1);
        }

        return arr[p1][p2];
    }
}