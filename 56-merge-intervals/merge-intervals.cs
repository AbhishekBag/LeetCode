public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length == 1) {
            return intervals;
        }

        List<int[]> res = new List<int[]>();

        Array.Sort(intervals, (x, y) => {
            return x[0].CompareTo(y[0]);
        });

        //1, 5     5, 6

        var start = intervals[0];
        bool merged = false;
        for(int i = 1; i < intervals.Length; i++) {
            var second = intervals[i];
            if(start[1] >= second[0]) {
                start[0] = Math.Min(start[0], second[0]);
                start[1] = Math.Max(start[1], second[1]);
            } else {
                res.Add(start);
                start = second;
            }
        }

        res.Add(start);

        return res.ToArray();
    }
}