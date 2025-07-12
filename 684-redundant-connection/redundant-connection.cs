public class Solution {
    private int[] parent;
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        parent = new int[n + 1];

        for(int i = 0; i < n; i++) {
            parent[i] = i;
        }

        foreach(var edge in edges) {
            int x = edge[0];
            int y = edge[1];

            if(Find(parent, x) == Find(parent, y)) {
                return edge;
            }

            Union(parent, x, y);
        }

        return new int[] {};
    }

    private int Find(int[] parent, int x) {
        if(x != parent[x]) {
            parent[x] = Find(parent, parent[x]);
        }

        return parent[x];
    }

    private void Union(int[] parent, int x, int y) {
        int px = Find(parent, x);
        int py = Find(parent, y);

        if(px != py) {
            parent[px] = py;
        }
    }
}

/*
1 2 3 4 5
    4 4
2 2
  4   4
    5   5
  5     5
*/