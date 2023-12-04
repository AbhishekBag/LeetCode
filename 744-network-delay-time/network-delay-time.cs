public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        if(n == 1) {
            return 0;
        }

        int[] d = new int[n + 1];
        HashSet<int> visited = new HashSet<int>();
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();
        Dictionary<int, List<Edge>> eMap = new Dictionary<int, List<Edge>>();

        for(int i = 0; i <= n; i++) {
            d[i] = Int32.MaxValue;
        }

        for(int i = 0; i < times.Length; i++) {
            int s = times[i][0];
            int ds = times[i][1];
            int w = times[i][2];
            if(eMap.ContainsKey(s)) {
                eMap[s].Add(new Edge(s, ds, w));
            } else {
                var edges = new List<Edge>();
                edges.Add(new Edge(s, ds, w));
                eMap.Add(s, edges);
            }
        }

        d[k] = 0;
        q.Enqueue(k, 0);
        while(q.Count > 0 && visited.Count() < n) {
            var poped = q.Dequeue();
            if(!visited.Contains(poped)) {
                visited.Add(poped);
            }

            if(eMap.ContainsKey(poped)) {
                var edges = eMap[poped];
                foreach(var edge in edges) {
                    // Console.WriteLine($"poped: {poped}; d[edge.d]: {d[edge.d]}; d[edge.s]: {d[edge.s]}; edge.w: {edge.w}");
                    if(d[edge.d] > d[edge.s] + edge.w) {
                        d[edge.d] = d[edge.s] + edge.w;
                        q.Enqueue(edge.d, d[edge.d]);
                        // Console.WriteLine($"Enqueuing {edge.d}");
                    }
                }
            }

            // Console.WriteLine();
            // Console.WriteLine();
        }

        int mCost = 0;
        for(int i = 1; i <= n; i++) {
            // Console.WriteLine($"cost of {i}: {d[i]};");
            mCost = Math.Max(mCost, d[i]);
        }

        return mCost == Int32.MaxValue ? -1 : mCost;
    }
}

public class Edge {
    public int s;
    public int d;
    public int w;

    public Edge(int _s, int _d, int _w) {
        s = _s;
        d = _d;
        w = _w;
    }
}