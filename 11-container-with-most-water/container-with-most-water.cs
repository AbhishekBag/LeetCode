public class Solution {
    public int MaxArea(int[] height) {
        int i = 0, j = height.Length - 1;
        int maxSum = 0, curSum = 0;

        while(i < j) {
            curSum = (j - i)*Math.Min(height[i], height[j]);
            maxSum = Math.Max(maxSum, curSum);

            if(height[i] == height[j]) {
                i++;
                j--;
            } else if(height[i] > height[j]) {
                j--;
            } else {
                i++;
            }
        }

        return maxSum;
    }
}

/*
index=  0,1,2,3,4,5,6,7,8
maxR=   8,8,8,8,8,8,8,8,7
maxL=   1,8,8,8,8,8,8,8,8
        1,8,6,2,5,4,8,3,7
*/