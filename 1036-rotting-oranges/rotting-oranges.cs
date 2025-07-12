public class Solution {
    private int R, C;
    private int[] moveR = new int[] { 1, 0, -1, 0 };
    private int[] moveC = new int[] { 0, 1, 0, -1 };
    public int OrangesRotting(int[][] grid) {
        Queue<(int i, int j)> q = new Queue<(int, int)>();
        int minutes = 0;
        R = grid.Length;
        C = grid[0].Length;

        int fresh = 0;

        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                if(grid[i][j] == 2) {
                    q.Enqueue((i, j));
                }
                else if(grid[i][j] == 1) {
                    fresh++;
                }
            }
        }

        while(q.Count > 0 && fresh > 0) {
            int count = q.Count;
            minutes++;
            while(count-- > 0) {
                (int i, int j) = q.Dequeue();

                for(int m = 0; m < 4; m++) {
                    int nI = i + moveR[m];
                    int nJ = j + moveC[m];

                    if(nI >= 0 && nI < R && nJ >= 0 && nJ < C && grid[nI][nJ] == 1) {
                        grid[nI][nJ] = 2;
                        q.Enqueue((nI, nJ));
                        fresh--;
                    }
                }
            }
        }

        return fresh == 0 ? minutes : -1;
    }
}