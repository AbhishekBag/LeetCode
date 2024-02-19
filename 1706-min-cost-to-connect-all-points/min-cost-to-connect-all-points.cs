public class Solution {
    public int MinCostConnectPoints(int[][] points)
    {
        int n = points.Length;
        int cost = 0;
        List<Edge> Edges = new List<Edge>();
        DisjointSet ds = new DisjointSet(n);

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var weight = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                Edges.Add(new Edge(i, j, weight));
            }
        }

        Edges.Sort((x, y) => {
            return x.w.CompareTo(y.w);
        });

        foreach(var edge in Edges) {
            if(!ds.AreConnected(edge.v1, edge.v2)) {
                cost += edge.w;
                ds.Union(edge.v1, edge.v2);
            }
        }

        return cost;
    }
}

public class Edge {
    public int v1 { get; set; }
    public int v2 { get; set; }
    public int w { get; set; }

    public Edge(int _a, int _b, int _w) {
        v1 = _a;
        v2 = _b;
        w = _w;
    }

    public override int GetHashCode()
    {
        return v1.GetHashCode() ^ v2.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if(obj is Edge)
        {
            var other = (Edge)obj;
            return v1.Equals(other.v1) && v2.Equals(other.v2);
        }

        return false;
    }
}

public class DisjointSet {
    public int n;
    public int[] parent;

    public DisjointSet(int x) {
        n = x;
        parent = new int[n];
        for(int i = 0; i < n; i++) {
            parent[i] = i;
        }
    }

    public int Find(int x) {
        if(parent[x] != x) {
            parent[x] = Find(parent[x]);
        }

        return parent[x];
    }

    public void Union(int x, int y) {
        var rootX = Find(x);
        var rootY = Find(y);

        if(rootX != rootY) {
            parent[rootX] = rootY;
        }
    }

    public bool AreConnected(int x, int y) {
        return Find(x) == Find(y);
    }
}