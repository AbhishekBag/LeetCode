public class Solution {
    int[][] mem;
    public int CoinChange(int[] coins, int amount) {
        // mem = Enumerable.Repeat(-1, amount + 1).ToArray().Repeat(coins.Length);

        mem = new int[coins.Length][];
        for(int i = 0; i < coins.Length; i++) {
            mem[i] = Enumerable.Repeat(-1, amount + 1).ToArray();
        }        

        int res = FindMinComb(coins, amount, 0);

        if(res >= 99999999) {
            return -1;
        }

        return res;
    }

    private int FindMinComb(int[] coins, int amount, int current) {
        if(amount == 0) {
            return 0;
        }

        if(current >= coins.Length || amount < 0) {
            return 99999999;
        }

        if(mem[current][amount] != -1) {
            return mem[current][amount];
        }

        int op1 = 1 + FindMinComb(coins, amount - coins[current], current);
        int op2 = FindMinComb(coins, amount, current + 1);

        mem[current][amount] = Math.Min(op1, op2);

        return mem[current][amount];
    }
}

/*
1, 2, 5    11
f() => 1 + f(11 - 1)   ,  f(11, next index)
*/