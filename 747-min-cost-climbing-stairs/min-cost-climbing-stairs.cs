public class Solution {
    int[] memo;
    public int MinCostClimbingStairs(int[] cost) {
        memo = Enumerable.Repeat(Int32.MaxValue, cost.Length + 1).ToArray();
        return Math.Min(FindCost(cost, 0), FindCost(cost, 1));
    }

    private int FindCost(int[] cost, int index) {
        if(index >= cost.Length) {
            return 0;
        }

        if(memo[index] != Int32.MaxValue) {
            return memo[index];
        }

        memo[index] = Math.Min((FindCost(cost, index + 1) + cost[index]), FindCost(cost, index + 2) + cost[index]);

        return memo[index];
    }
}