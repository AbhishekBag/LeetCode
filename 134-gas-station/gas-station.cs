public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalGas = 0, totalCost = 0;
        int availableGas = 0;
        int start = 0;

        for(int i = 0; i < gas.Length; i++) {
            totalGas += gas[i];
            totalCost += cost[i];
            availableGas += gas[i] - cost[i];

            if(availableGas < 0) {
                start = i + 1;
                availableGas = 0;
            }
        }

        return totalGas >= totalCost ? start : -1;
    }
}


/*
5
0,1,2,3,4
1,2,3,4,5

2+4=>6%5=1
*/