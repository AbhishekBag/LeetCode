public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> resList = new List<int[]>();
        bool added = false;

        if(intervals.Length == 0) {
            resList.Add(new int[] { newInterval[0], newInterval[1] });
            added = true;
        }

        for(int i = 0; i < intervals.Length; i++) {
            var intervalInHand = intervals[i];
            if(newInterval[1] < intervalInHand[0]) {
                resList.Add(new int[] { newInterval[0], newInterval[1]} );
                AddIntervals(resList, intervals, i);
                added = true;
                break;
            } else if(newInterval[0] > intervalInHand[1]) {
                resList.Add(new int[] { intervalInHand[0], intervalInHand[1]} );
            } else {
                newInterval[0] = Math.Min(newInterval[0], intervalInHand[0]);
                newInterval[1] = Math.Max(newInterval[1], intervalInHand[1]);
            }
        }

        if(!added) {
            resList.Add(new int[] { newInterval[0], newInterval[1]} );
        }

        return resList.ToArray();
    }

    private void AddIntervals(List<int[]> resList, int[][] intervals, int i) {
        while(i < intervals.Length) {
            resList.Add(new int[]{ intervals[i][0], intervals[i][1]} );
            i++;
        }
    }
}