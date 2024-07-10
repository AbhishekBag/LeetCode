public class Solution {
    public int[] ReplaceElements(int[] arr) {
        List<int> Leaders = new List<int>();
        int currentLeader = -1;
        
        for(int i = arr.Length - 1; i >= 0; i--) {
            Leaders.Insert(0, currentLeader);
            currentLeader = Math.Max(currentLeader, arr[i]);
        }
        
        // Leaders[arr.Length - 1] = -1;
        return Leaders.ToArray();;
    }
}