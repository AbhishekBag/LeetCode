public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int[] leaders = new int[arr.Length];
        int currentLeader = -1;
        
        for(int i = arr.Length - 1; i >= 0; i--) {
           leaders[i] = currentLeader;
            currentLeader = Math.Max(currentLeader, arr[i]);
        }
        
        return leaders;
    }
}