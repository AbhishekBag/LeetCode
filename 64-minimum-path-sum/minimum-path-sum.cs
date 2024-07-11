public class Solution {
    public int MinPathSum(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;

        int[][] mem = new int[n][];

        for(int i = 0; i < n; i++) {
            mem[i] = Enumerable.Repeat(0, m).ToArray();
            // mem[i][0] = grid[i][0];
        }
        
        int sum = 0;
        for(int i = 0; i < m; i++) {
            sum += grid[0][i];
            mem[0][i] = sum;
        }

        sum = 0;
        for(int i = 0; i < n; i++) {
            sum += grid[i][0];
            mem[i][0] = sum;
        }

        for(int  i = 1; i < n; i++) {
            for(int j = 1; j < m; j++) {
                mem[i][j] = Math.Min(mem[i - 1][j], mem[i][j - 1]) + grid[i][j];
            }
        }

        // display(mem);

        return mem[n -1][m - 1];
    }

    private void display(int[][] mem) {
        int n = mem.Length;
        int m = mem[0].Length;
        for(int  i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
                Console.Write($"{mem[i][j]} ");
            }

            Console.WriteLine();
        }
    }
}