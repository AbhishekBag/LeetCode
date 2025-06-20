public class Solution {
    public void Solve(char[][] board) {
        int R = board.Length;
        int C = board[0].Length;

        for(int i = 0; i < R; i++) {
            DFS(board, i, 0);
            DFS(board, i, C - 1);
        }

        for(int j = 0; j < board[0].Length; j++) {
            DFS(board, 0, j);
            DFS(board, R - 1, j);
        }

        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                if(board[i][j] != '#') {
                    board[i][j] = 'X';
                } else {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void DFS(char[][] board, int r, int c) {
        int R = board.Length;
        int C = board[0].Length;

        if(r < 0 || r >= R || c < 0 || c >= C || board[r][c] != 'O') {
            return;
        }

        board[r][c] = '#';

        DFS(board, r - 1, c);
        DFS(board, r + 1, c);
        DFS(board, r, c - 1);
        DFS(board, r, c + 1);
    }
}