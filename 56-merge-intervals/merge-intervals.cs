public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => { return a[0].CompareTo(b[0]);});
        List<int[]> res = new List<int[]>();
        var curr = intervals[0];

        for(int i = 1; i < intervals.Length; i++) {
            var next = intervals[i];
            if(IsOverlapping(curr, next)) {
                curr[0] = Math.Min(curr[0], next[0]);
                curr[1] = Math.Max(curr[1], next[1]);
            } else {
                res.Add(curr);
                curr = next;
            }
        }

        res.Add(curr);

        return res.ToArray();
    }

    private bool IsOverlapping(int[] a, int[] b) {
        return Math.Max(a[0], b[0]) <= Math.Min(a[1], b[1]);
    }
}