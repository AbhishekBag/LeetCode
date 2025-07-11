public class Solution {
    private int R;
    private int C;
    private int[] rowMove = new int[] { 1, 0, -1, 0 };
    private int[] colMove = new int[] { 0, 1, 0, -1 };
    public int NumIslands(char[][] grid) {
        R = grid.Length;
        C = grid[0].Length;
        int count = 0;

        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                if(grid[i][j] == '1') {
                    count++;
                    MarkIsland(grid, i, j);
                }
            }
        }

        return count;
    }

    private void MarkIsland(char[][] grid, int i, int j) {
        if(i < 0 || i >= R || j < 0 || j >= C || grid[i][j] != '1') {
            return;
        }

        grid[i][j] = '*';

        for(int m = 0; m < 4; m++) {
            MarkIsland(grid, i + rowMove[m], j + colMove[m]);
        }
    }
}