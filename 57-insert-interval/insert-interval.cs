public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new List<int[]>();
        bool added = false;

        for(int i = 0; i < intervals.Length; i++) {
            var curr = intervals[i];
            if(curr[0] > newInterval[1]) {
                res.Add(new int[] { newInterval[0], newInterval[1] });
                AddIntervals(res, intervals, i);
                added = true;
                break;
            } else if(curr[1] < newInterval[0]) {
                res.Add(new int[] { curr[0], curr[1]});
            } else {
                newInterval[0] = Math.Min(curr[0], newInterval[0]);
                newInterval[1] = Math.Max(curr[1], newInterval[1]);
            }
        }

        if(!added) {
            res.Add(new int[] { newInterval[0], newInterval[1] });
        }

        return res.ToArray();
    }

    private void AddIntervals(List<int[]> res, int[][] intervals, int i) {
        for(; i < intervals.Length; i++) {
            res.Add(new int[] { intervals[i][0], intervals[i][1]});
        }
    }
}