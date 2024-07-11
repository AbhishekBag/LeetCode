public class Solution {
    private int minSum = Int32.MaxValue;
    public int MinPathSum(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int[][] mem = new int[n][];

        for(int i = 0; i < n; i++) {
            mem[i] = Enumerable.Repeat(-1, m).ToArray();
        }

        return GetMinSum(grid, 0, 0, mem);
    }

    private int GetMinSum(int[][] grid, int i, int j, int[][] mem) {
        int n = grid.Length;
        int m = grid[0].Length;

        if(i < 0 || i >= n || j < 0 || j >= m) {
            return Int32.MaxValue;
        }

        if(i == n - 1 && j == m - 1) {
            return grid[i][j];
        }

        if(mem[i][j] != -1) {
            return mem[i][j];
        }

        int bottomSum = GetMinSum(grid, i + 1, j, mem);
        int rightSum = GetMinSum(grid, i, j + 1, mem);

        mem[i][j] = Math.Min(bottomSum, rightSum) + grid[i][j];

        return mem[i][j];
    }
}