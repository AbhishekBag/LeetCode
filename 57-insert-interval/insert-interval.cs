public class Solution {    
    private List<int[]> arr = new List<int[]>();
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        Merge(intervals, newInterval, 0);

        return arr.ToArray();
    }

    private void Merge(int[][] intervals, int[] newInterval, int i) {
        if(i >= intervals.Length) {
            arr.Add(newInterval);
            return;
        }

        if(intervals[i][0] > newInterval[1]) {
            arr.Add(newInterval);
            // arr.AddRange(intervals);
            AddRemaining(intervals, i);
            return;
        } else if(intervals[i][1] < newInterval[0]){
            arr.Add(intervals[i]);
            Merge(intervals, newInterval, i + 1);
        } else if(IsOverlaping(intervals[i], newInterval)) {
            arr.Add(intervals[i]);
            MergeInterval(arr, newInterval);
            i++;

            for(; i < intervals.Length; i++) {
                if(IsOverlaping(arr.LastOrDefault(), intervals[i])) {
                    MergeInterval(arr, intervals[i]);
                } else {
                    AddRemaining(intervals, i);
                    return;
                }
            }
        }
    }

    private void AddRemaining(int[][] intervals, int i) {
        for(; i < intervals.Length; i++) {
            arr.Add(intervals[i]);
        }
    }

    private bool IsOverlaping(int[] a, int[] b) {
        return Math.Max(a[0], b[0]) <= Math.Min(a[1], b[1]);
    }

    private void MergeInterval(List<int[]> lst, int[] a) {
        var b = lst.LastOrDefault();
        b[0] = Math.Min(b[0], a[0]);
        b[1] = Math.Max(b[1], a[1]);
    }
}