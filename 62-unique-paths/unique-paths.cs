public class Solution {
    int[][] arr;
    public int UniquePaths(int m, int n) {
        arr = new int[m][];
        for(int i = 0; i < m; i++) {
            arr[i] = Enumerable.Repeat(-1, n).ToArray();
        }

        return CountPaths(m, n, 0, 0);
    }

    private int CountPaths(int m, int n, int i, int j) {
        if(i < 0 || i >= m || j < 0 || j >= n) {
            return 0;
        }

        if(i == m - 1 &&  j == n - 1) {
            return 1;
        }

        if(arr[i][j] != -1) {
            return arr[i][j];
        }

        int rightPaths = CountPaths(m, n, i, j + 1);
        int downPaths = CountPaths(m, n, i + 1, j);

        arr[i][j] = rightPaths + downPaths;

        return arr[i][j];
    }
}