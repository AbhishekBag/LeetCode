public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int minTill = prices[0];

        for(int i = 1; i < prices.Length; i++) {
            minTill = Math.Min(minTill, prices[i]);
            profit = Math.Max(profit, prices[i] - minTill);
        }

        return profit;
    }
}