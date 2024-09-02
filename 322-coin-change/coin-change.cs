public class Solution {
    private int[][] arr;
    public int CoinChange(int[] coins, int amount) {
        arr = new int[coins.Length][];
        for(int i = 0; i < coins.Length; i++) {
            arr[i] = Enumerable.Repeat(Int32.MinValue, amount + 1).ToArray();
        }
        
        var res = PickCoin(coins, amount, coins.Length - 1);

        return res >= Int32.MaxValue ? -1 : res;
    }

    private int PickCoin(int[] coins, int amount, int index) {
        if(amount < 0 || index < 0) {
            return Int32.MaxValue;
        }

        if(amount == 0) {
            return 0;
        }

        if(arr[index][amount] != Int32.MinValue) {
            return arr[index][amount];
        }

        int pk = PickCoin(coins, amount - coins[index], index);
        int picked = pk == Int32.MaxValue ? Int32.MaxValue : pk + 1;
        int notPicked = PickCoin(coins, amount, index - 1);

        int path = Math.Min(picked, notPicked);

        arr[index][amount] = path;

        return path;
    }
}