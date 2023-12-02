public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int R = matrix.Length;
        int C = matrix[0].Length;
        if(R == 1 && C == 1) {
            if(matrix[R - 1][C - 1] == '1') {
                return 1;
            } else {
                return 0;
            }
        }

        int max = 0;
        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                
                // Console.WriteLine($"i: {i}; j: {j}; max: {max}");

                if(matrix[i][j] == '1') {
                    int s = 1;
                    int m = i + 1;
                    int n = j + 1;

                    while(IsNextValid(matrix, i, j, m, n)) {
                        s++;
                        m++;
                        n++;
                    }

                    max = Math.Max(max, s);
                }

                // Console.WriteLine();
                // Console.WriteLine();
            }
        }

        return max * max;
    }

    private bool IsNextValid(char[][] matrix, int r, int c, int m, int n) {
        int R = matrix.Length;
        int C = matrix[0].Length;

        // Console.WriteLine($"r: {r}, c: {c}, m: {m}, n: {n}");

        if(m < R && n < C && matrix[m][n] == '1') {
            for(int i = r; i <= m; i++) {
                if(matrix[i][n] != '1') {
                    return false;
                }
            }

            for(int j = c; j <= n; j++) {
                if(matrix[m][j] != '1') {
                    return false;
                }
            }

            return true;
        }

        return false;
    }
}