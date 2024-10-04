public class Solution {
    private int[] rowMove;
    private int[] colMove;
    public int NumIslands(char[][] grid) {
        rowMove = new int[] { 0, 1, 0, -1 };
        colMove = new int[] { 1, 0, -1, 0 };
        int count = 0;
        int R = grid.Length;
        int C = grid[0].Length;

        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                // Console.Write($"{grid[i][j]} ");
                if(grid[i][j] == '1') {
                    count++;
                    MarkIsland(grid, i, j);
                }
            }

            // Console.WriteLine();
        }

        return count;
    }

    private void MarkIsland(char[][] grid, int r, int c) {
        int R = grid.Length;
        int C = grid[0].Length;

        if(r < 0 || r >= R || c < 0 || c >= C) {
            return;
        }

        if(grid[r][c] == '1') {
            grid[r][c] = '*';
            for(int i = 0; i < 4; i++) {
                MarkIsland(grid, r + rowMove[i], c + colMove[i]);
            }
        }
    }
}