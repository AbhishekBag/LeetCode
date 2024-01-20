public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] arr = Enumerable.Repeat(-1, cost.Length).ToArray();
        
        return GetMinCost(cost, arr, cost.Length - 1);
    }

    private int GetMinCost(int[] cost, int[] arr, int i) {
        if(i <= 0) {
            return 0;
        }

        int p1 = 0, p2 = 0;
        if(arr[i] != -1) {
            return arr[i];
        }

        p1 = cost[i] + GetMinCost(cost, arr, i - 1);
        p2 = cost[i - 1] + GetMinCost(cost, arr, i - 2);

        arr[i] = Math.Min(p1, p2);
        return arr[i];
    }

    private void DisplayCost(int[] arr) {
        foreach(var item in arr) {
            Console.Write($"{item}, ");
        }

        Console.WriteLine();
    }
}