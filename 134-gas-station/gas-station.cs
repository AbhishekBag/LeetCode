public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = 0;
        int availableGas = 0;
        int totalGas = 0, totalCost = 0;

        for(int i = 0; i < gas.Length; i++) {
            totalGas += gas[i];
            totalCost += cost[i];
            availableGas += gas[i] - cost[i];

            if(availableGas < 0) {
                availableGas = 0;
                start = i + 1;
            }
        }

        return totalGas >= totalCost ? start : -1;
    }
}