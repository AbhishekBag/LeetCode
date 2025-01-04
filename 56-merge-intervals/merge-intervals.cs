public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length <= 1) {
            return intervals;
        }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> res = new List<int[]>();
        var cur = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            var next = intervals[i];
            if(IsOverlapping(cur, next)) {
                cur[0] = Math.Min(cur[0], next[0]);
                cur[1] = Math.Max(cur[1], next[1]);
            } else {
                res.Add(cur);
                cur = next;
            }
        }

        res.Add(cur);

        return res.ToArray();
    }

    private bool IsOverlapping(int[] a, int[] b) {
        return Math.Max(a[0], b[0]) <= Math.Min(a[1], b[1]);
    }
}