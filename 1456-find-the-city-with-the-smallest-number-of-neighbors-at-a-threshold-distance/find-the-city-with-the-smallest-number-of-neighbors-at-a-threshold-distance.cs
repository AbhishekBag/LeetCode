public class Solution {
    // Create Adjacancy List
    // For all nodes, apply Digstra algo to find all nodes reachable with thresold weight
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
        Dictionary<int, List<Edge>> adjList = GetAdjMatrix(edges);

        int minReachable = Int32.MaxValue;
        int ansCity = -1;
        for(int i = 0; i < n; i++) {
            HashSet<int> reachableCities = GetNearbyNodes(n, edges, adjList, i, distanceThreshold);
            // Console.WriteLine($"{i}: {reachableCities.Count()}");
            // PrintReachableCities(reachableCities);

            if(minReachable >= reachableCities.Count()) {
                minReachable = reachableCities.Count();
                ansCity = Math.Max(ansCity, i);
            }
        }

        return ansCity;
    }

    private HashSet<int> GetNearbyNodes(int n, int[][] edges, Dictionary<int, List<Edge>> adjList, int sourceCity, int distanceThresold) {
        HashSet<int> reachableCities = new HashSet<int>();
        int[] cost = Enumerable.Repeat(Int32.MaxValue, n).ToArray();
        Queue<int> currentSet = new Queue<int>();

        cost[sourceCity] = 0;
        currentSet.Enqueue(sourceCity);
        while(currentSet.Count() > 0) {
            var source = currentSet.Dequeue();

            if(adjList.ContainsKey(source)){
                var reachableEdges = adjList[source];
                foreach(var edge in reachableEdges) {
                    var newWeight = cost[source] + edge.w;
                    if(cost[edge.d] > newWeight && newWeight <= distanceThresold) {
                        cost[edge.d] = newWeight;
                        currentSet.Enqueue(edge.d);
                        reachableCities.Add(edge.d);
                    }
                }
            }            
        }

        return reachableCities;
    }

    private void PrintReachableCities(HashSet<int> cities) {
        foreach(var city in cities) {
            Console.Write($"{city}, ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    private Dictionary<int, List<Edge>> GetAdjMatrix(int[][] edges) {
        Dictionary<int, List<Edge>> adjList = new Dictionary<int, List<Edge>>();
        foreach(var edge in edges) {
            var source = edge[0];
            var dest = edge[1];
            var weight = edge[2];

            if(!adjList.ContainsKey(source)) {
                adjList[source] = new List<Edge>();
            }

            if(!adjList.ContainsKey(dest)) {
                adjList[dest] = new List<Edge>();
            }

            adjList[source].Add(new Edge(source, dest, weight));
            adjList[dest].Add(new Edge(dest, source, weight));
        }

        return adjList;
    }
}

public class Edge {
    public int s { get; set; }
    public int d { get; set; }
    public int w { get; set; }

    public Edge(int _s, int _d, int _w) {
        s = _s;
        d = _d;
        w = _w;
    }
}