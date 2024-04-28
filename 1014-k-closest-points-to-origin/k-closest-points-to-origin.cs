public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> pQ = new PriorityQueue<int[], double>();
        foreach(var point in points) {
            pQ.Enqueue(point, GetDistance(point));
        }

        int[][] res = new int[k][];
        for(int i = 0; i < k; i++) {
            res[i] = pQ.Dequeue();
        }

        return res;
    }

    private double GetDistance(int[] point) {
        return Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
    }
}