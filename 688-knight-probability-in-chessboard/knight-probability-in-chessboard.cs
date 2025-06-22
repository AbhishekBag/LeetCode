public class Solution {
    private double[,,] memo;
    private int[,] dirs = new int[,] {
            { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 },
            { 2, 1 }, { 2, -1 }, { -2, 1}, {-2, -1 }
        };
    public double KnightProbability(int n, int k, int row, int column) {
        memo = new double[n, n, k + 1];
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                for(int m = 0; m <= k; m++) {
                    memo[i, j, m] = -1.0;
                }
            }
        }

        return DFS(n, row, column, k);

        /*
        double probability = 0;
        Queue<(int x, int y, int level, double prob)> q = new Queue<(int, int, int, double)>();

        q.Enqueue((row, column, 0, 1));

        while(q.Count > 0) {
            (int x, int y, int level, double prob) = q.Dequeue();

            if(k == level) {
                probability += prob;
            } else if(k > level) {
                for(int i = 0; i < 8; i++) {
                    int nx = x + dirs[i, 0];
                    int ny = y + dirs[i, 1];

                    if(nx >= 0 && nx < n && ny >= 0 && ny < n) {
                        q.Enqueue((nx, ny, level + 1, prob/8));
                    }                  
                }
            }
        }
        
        return probability;
        */
    }

    private double DFS(int n, int x, int y, int k) {
        if(x < 0 || x >= n || y < 0 || y >= n) {
            return 0.0;
        }

        if(k == 0) {
            return 1.0;
        }

        if(memo[x, y, k] != -1.0) {
            return memo[x, y, k];
        }

        double prob = 0.0;
        for(int i = 0; i < 8; i++) {
            int nx = x + dirs[i, 0];
            int ny = y + dirs[i, 1];

            prob += DFS(n, nx, ny, k - 1) / 8.0;
        }

        memo[x, y, k] = prob;
        return prob;
    }
}