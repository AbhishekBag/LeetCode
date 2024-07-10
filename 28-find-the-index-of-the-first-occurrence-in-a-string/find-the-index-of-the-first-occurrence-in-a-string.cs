public class Solution {
    public int StrStr(string haystack, string needle) {
        int m = needle.Length;
        int n = haystack.Length;

        if(n < 0 || m < 0) {
            return -1;
        }

        for(int i = 0; i <= n - m; i++) {
            for(int j = 0; j < m && haystack[i + j] == needle[j]; j++) {
                if(j == m - 1) {
                    return i;
                }
            }
        }

        return -1;
    }
}
/*
0  1  2  3  4
h  e  l  l  o

0 1
l l

i: 2
j: 0
*/