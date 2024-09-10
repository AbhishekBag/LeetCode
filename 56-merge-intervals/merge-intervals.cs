public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length == 0) {
            return intervals;
        }

        List<int[]> res = new List<int[]>();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var current = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            var upcoming = intervals[i];
            if(IsOverlapping(current, upcoming)) {
                current[0] = Math.Min(current[0], upcoming[0]);
                current[1] = Math.Max(current[1], upcoming[1]);
            } else {
                res.Add(current);
                current = upcoming;
            }
        }

        res.Add(current);

        return res.ToArray();
    }

    private bool IsOverlapping(int[] interval1, int[] interval2) {
        return Math.Max(interval1[0], interval2[0]) <= Math.Min(interval1[1], interval2[1]);
    }
}