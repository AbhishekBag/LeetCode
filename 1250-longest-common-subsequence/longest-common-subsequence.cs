public class Solution {
    private int[][] arr;
    public int LongestCommonSubsequence(string text1, string text2) {
        arr = new int[text1.Length][];
        for(int i = 0; i < text1.Length; i++) {
            arr[i] = Enumerable.Repeat(-1, text2.Length).ToArray();
        }
        
        return GetMaxSubsequenceLength(text1, text2, 0, 0);

        // return arr[text1.Length - 1][text2.Length - 1];
    }

    private int GetMaxSubsequenceLength(string text1, string text2, int i, int j) {
        if(i >= text1.Length || j >= text2.Length) {
            return 0;
        }

        if(arr[i][j] != -1) {
            return arr[i][j];
        }

        if(text1[i] == text2[j]) {
            arr[i][j] = 1 + GetMaxSubsequenceLength(text1, text2, i + 1, j + 1);
        } else {
            arr[i][j] = Math.Max(GetMaxSubsequenceLength(text1, text2, i + 1, j),
        GetMaxSubsequenceLength(text1, text2, i, j + 1));
        }        

        return arr[i][j];
    }
}

/*
str1 = abcde (i)
str2 = ace (j)

i > l1 || j > l2
return 0;

str1[i] == str2[j]
return 1 + f(str1, str2, i + 1, j + 1)

return Max(f(str1, str2, i + 1,j), f(str1, str2, i, j + 1))
*/