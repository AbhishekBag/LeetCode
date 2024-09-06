public class Solution {
    private int[][] arr;
    public int LongestCommonSubsequence(string text1, string text2) {
        arr = new int[text1.Length][];
        for(int i = 0; i < text1.Length; i++) {
            arr[i] = Enumerable.Repeat(-1, text2.Length).ToArray();
        }

        return FindMaxLength(text1, text2, 0, 0);
    }

    private int FindMaxLength(string str1, string str2, int i, int j) {
        if(i >= str1.Length || j >= str2.Length) {
            return 0;
        }

        if(arr[i][j] != -1) {
            return arr[i][j];
        }

        if(str1[i] == str2[j]) {
            arr[i][j] = 1 + FindMaxLength(str1, str2, i + 1, j + 1);
        } else {
            arr[i][j] = Math.Max(FindMaxLength(str1, str2, i + 1, j), FindMaxLength(str1, str2, i, j + 1));
        }

        return arr[i][j];
    }
}