public class Solution {
    private int[][] mem;
    public int CoinChange(int[] coins, int amount) {
        mem = new int[coins.Length][];
        for(int i = 0; i < coins.Length; i++) {
            mem[i] = Enumerable.Repeat(-1, amount + 1).ToArray();
        }

        int count = GetCoinCount(coins, amount, 0);

        if(count >= 99999999) {
            return -1;
        }

        return count;
    }

    private int GetCoinCount(int[] coins, int amount, int index) {
        if(amount < 0 || index >= coins.Length) {
            return 99999999;
        }

        if(amount == 0) {
            return 0;
        }

        if(mem[index][amount] != -1) {
            return mem[index][amount];
        }

        int count1 = 1 + GetCoinCount(coins, amount - coins[index], index);
        int count2 = GetCoinCount(coins, amount, index + 1);

        mem[index][amount] = Math.Min(count1, count2);

        return mem[index][amount];
    }
}