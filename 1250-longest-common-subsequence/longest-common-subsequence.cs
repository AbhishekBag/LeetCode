public class Solution {
    private int[][] arr;
    public int LongestCommonSubsequence(string text1, string text2) {
        arr = new int[text1.Length][];
        for(int i = 0; i < text1.Length; i++) {
            arr[i] = Enumerable.Repeat(-1, text2.Length).ToArray();
        }

        return FindLCS(text1, text2, 0, 0);
    }

    private int FindLCS(string text1, string text2, int i, int j) {
        if(i >= text1.Length || j >= text2.Length) {
            return 0;
        }

        if(arr[i][j] != -1) {
            return arr[i][j];
        }

        if(text1[i] != text2[j]) {
            arr[i][j] = Math.Max(FindLCS(text1, text2, i + 1, j), FindLCS(text1, text2, i, j + 1));
        } else {
            arr[i][j] = 1 + FindLCS(text1, text2, i + 1, j + 1);
        }

        return arr[i][j];
    }
}