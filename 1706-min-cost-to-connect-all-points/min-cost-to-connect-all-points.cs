public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        PriorityQueue<Edge, int> pq = new PriorityQueue<Edge, int>();

        for(int i = 0; i < n; i++) {
            for(int j = i + 1; j < n;  j++) {
                int d = GetDistance(points, i, j);
                pq.Enqueue(new Edge(i, j, d), d);
            }
        }

        UnionFind uf = new UnionFind(n);
        int minCost = 0;
        int vCount = 0;
        while(vCount <= n - 1 && pq.Count > 0) {
            Edge pEdge = pq.Dequeue();
            if(uf.Union(pEdge.v1, pEdge.v2)) {
                minCost += pEdge.d;
                vCount++;
            }
        }

        return minCost;
    }

    private int GetDistance(int[][] points, int x, int y) {
        return Math.Abs(points[x][0] - points[y][0]) + Math.Abs(points[x][1] - points[y][1]);
    }
}

public class Edge {
    public int v1;
    public int v2;
    public int d;

    public Edge(int _a, int _b, int _d) {
        v1 = _a;
        v2 = _b;
        d = _d;
    }
}

class UnionFind {
    public int[] parent;

    public UnionFind(int size) {
        parent = new int[size];
        for(int i = 0; i < size; i++) {
            parent[i] = i;
        }
    }

    public int Find(int node) {
        if(node != parent[node]) {
            parent[node] = Find(parent[node]);
        }

        return parent[node];
    }

    public bool Union(int n1, int n2) {
        int root1 = Find(n1);
        int root2 = Find(n2);

        if(root1 == root2) {
            return false;
        }

        parent[root1] = root2;
        return true;
    }
}