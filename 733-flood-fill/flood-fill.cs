public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(color == image[sr][sc]) {
            return image;
        }

        FillColor(image, sr, sc, color, image[sr][sc]);

        return image;
    }

    private void FillColor(int[][] image, int sr, int sc, int targetColor, int givenColor) {
        int R = image.Length;
        int C = image[0].Length;    
        int[] r = new int[] { 1, 0, -1, 0 };
        int[] c = new int[] { 0, 1, 0, -1 };

        if(sr < 0 || sr >= R || sc < 0 || sc >= C || image[sr][sc] != givenColor) {
            return;
        }

        image[sr][sc] = targetColor;
        for(int i = 0; i < r.Length; i++) {
            FillColor(image, sr + r[i], sc + c[i], targetColor, givenColor);
        }
    }
}