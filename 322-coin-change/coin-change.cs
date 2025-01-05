public class Solution {
    private int[][] arr;
    public int CoinChange(int[] coins, int amount) {
        arr = new int[amount + 1][];
        for(int i = 0; i <= amount; i++) {
            arr[i] = Enumerable.Repeat(Int32.MaxValue, coins.Length).ToArray();
        }
        
        var count = CountCoins(coins, amount, 0);
        if(count >= 99999) {
            return -1;
        }

        return count;
    }

    private int CountCoins(int[] coins, int amount, int index) {
        if(amount < 0 || index >= coins.Length) {
            return 99999;
        }

        if(amount == 0) {
            return 0;
        }

        if(arr[amount][index] != Int32.MaxValue) {
            return arr[amount][index];
        }

        arr[amount][index] = Math.Min(1 + CountCoins(coins, amount - coins[index], index), CountCoins(coins, amount, index + 1));

        return arr[amount][index];
    }
}