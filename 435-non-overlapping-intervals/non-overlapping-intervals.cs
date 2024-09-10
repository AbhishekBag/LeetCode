public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length <= 1) {
            return 0;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int res = 0;
        int prevEnd = intervals[0][1];
        for(int i = 1; i < intervals.Length; i++) {
            int start = intervals[i][0];
            int end = intervals[i][1];
            if(prevEnd > start) {
                res++;
                prevEnd = Math.Min(prevEnd, end);
            } else {
                prevEnd = end;
            }
        }

        return res;
    }
}

/*
[[1,2],[2,3],[3,4],[1,3]]

[[1,2],[1,3],[2,3],[3,4]]
*/