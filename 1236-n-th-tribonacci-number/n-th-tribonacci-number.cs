public class Solution {
    int[] arr;
    public int Tribonacci(int n) {
        arr = Enumerable.Repeat(-1, n + 1).ToArray();
        return GetNthNumber(n);
    }

    private int GetNthNumber(int n) {
        if(n <= 1) {
            return n;
        }

        if(n == 2) {
            return 1;
        }

        if(arr[n] != -1) {
            return arr[n];
        }

        arr[n] = GetNthNumber(n - 3) + GetNthNumber(n - 2) + GetNthNumber(n - 1);

        return arr[n];
    }
}