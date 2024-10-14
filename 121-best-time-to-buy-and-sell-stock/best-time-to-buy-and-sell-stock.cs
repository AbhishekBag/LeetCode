public class Solution {
    public int MaxProfit(int[] prices) {
        int minTill = Int32.MaxValue;
        int maxProfit = 0;
        foreach(int price in prices) {
            minTill = Math.Min(minTill, price);
            maxProfit = Math.Max(maxProfit, price - minTill);
        }

        return maxProfit;
    }
}