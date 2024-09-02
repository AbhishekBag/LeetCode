public class Solution {
    private int[][] arr;
    public int CoinChange(int[] coins, int amount) {
        arr = new int[coins.Length][];
        for(int i = 0; i < coins.Length; i++) {
            arr[i] = Enumerable.Repeat(Int32.MaxValue, amount + 1).ToArray();
        }
        
        var res = PickCoin(coins, amount, coins.Length - 1);

        return res >= 99999 ? -1 : res;
    }

    private int PickCoin(int[] coins, int amount, int index) {
        if(amount < 0 || index < 0) {
            return 99999;
        }

        if(amount == 0) {
            return 0;
        }

        if(arr[index][amount] != Int32.MaxValue) {
            return arr[index][amount];
        }

        int picked = PickCoin(coins, amount - coins[index], index);
        int notPicked = PickCoin(coins, amount, index - 1);

        int path = Math.Min(picked + 1, notPicked);

        arr[index][amount] = path;

        return path;
    }
}