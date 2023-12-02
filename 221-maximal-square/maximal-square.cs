public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int maxD = 0;
        for (int r = 0; r<matrix.Length; r++) {
            for(int c=0; c<matrix[0].Length; c++) {
                if (matrix[r][c] == '1') {
                    maxD = Math.Max(maxD, 1);
                    maxD = Math.Max(maxD, getMaxDiagonal(matrix, r, c));
                }
            }
        }
        return maxD * maxD;        
    }

    private int getMaxDiagonal(char[][] matrix, int r, int c) {
        int maxD = 1;
        int startR = r;
        int startC = c;
        int newR = r;
        int newC = c;

        while(newR < matrix.Length-1 && newC < matrix[0].Length-1 ) {
            newR++;
            newC++;
            // maxD++;

            if (!checkNewRowColumn(matrix, startR, newR, startC, newC)) {
                return maxD;
            }
            maxD++;
        }

        return maxD;   
    }

    private bool checkNewRowColumn (char[][] matrix, int startR, int newR, int startC, int newC) {
        if(matrix[newR][newC] != '1') {
            return false;
        }

        for (int r = startR; r<=newR; r++) {
            if (matrix[r][newC] == '0') {
                return false;
            } 
        }

        for (int c = startC; c<=newC; c++) {
            if (matrix[newR][c] == '0') {
                return false;
            } 
        }

        return true;
    }

}