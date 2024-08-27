public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) {
            return 0;
        }

        int max = 0;
        int minTill = prices[0];

        for(int i = 1; i < prices.Length; i++) {
            minTill = Math.Min(minTill, prices[i]);
            max = Math.Max(max, prices[i] - minTill);
        }

        return max;
    }
}

/*
7,1,5,3,6,4
7,6,6,6,6,4

max = 0
minTill = 7

1
minTill = 1
max = Max(max, (1-minTill)) = 0

2
minTill = 1
max = Max(max, (5, minTill)) = 4
*/