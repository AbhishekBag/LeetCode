public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => {
            return a[0].CompareTo(b[0]);
        });

        List<int[]> res =  new List<int[]>();
        var current = intervals[0];
        for(int i = 1; i < intervals.Length; i++) {
            var next = intervals[i];
            if(current[1] >= next[0]) {
                current[0] = Math.Min(current[0], next[0]);
                current[1] = Math.Max(current[1], next[1]);
            } else {
                res.Add(current);
                current = next;
            }
        }

        res.Add(current);

        return res.ToArray();
    }
}