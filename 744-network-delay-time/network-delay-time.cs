public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int[] d = new int[n + 1];
        Queue<int> currentSet = new Queue<int>();
        // HashSet<int> visited = new HashSet<int>();
        Dictionary<int, List<(int destination, int weight)>> adjList = new Dictionary<int, List<(int destination, int weight)>>();

        for(int i = 0; i <= n; i++) {
            d[i] = Int32.MaxValue;
        }

        adjList = GetAdjList(times);
        d[k] = 0;
        currentSet.Enqueue(k);
        while(currentSet.Count() > 0) {
            var currentNode = currentSet.Dequeue();

            // if(!visited.Contains(currentNode)) {
            //     visited.Add(currentNode);                               
            // }

            if(adjList.ContainsKey(currentNode)){
                var destNodeItems = adjList[currentNode];
                foreach(var nextNodeItem in destNodeItems) {
                    var nextNode = nextNodeItem.destination;
                    var nextWeight = nextNodeItem.weight;

                    if(d[nextNode] > nextWeight + d[currentNode]) {
                        d[nextNode] = nextWeight + d[currentNode];
                        currentSet.Enqueue(nextNode);
                    }
                }
            } 
        }

        var mCost = 0;
        for(int i = 1; i <= n; i++) {
            mCost = Math.Max(mCost, d[i]);
        }

        return mCost == Int32.MaxValue ? -1 : mCost;
    }

    private Dictionary<int, List<(int, int)>> GetAdjList(int[][] times) {
        Dictionary<int, List<(int destination, int weight)>> adjList = new Dictionary<int, List<(int destination, int weight)>>();

        foreach(var item in times) {
            var source = item[0];
            var dest = item[1];
            var weight = item[2];

            if(!adjList.ContainsKey(source)) {
                adjList[source] = new List<(int, int)>();
            }

            adjList[source].Add((dest, weight));
        }
        
        return adjList;
    }

    private void DisplayAdjList(Dictionary<int, List<(int destination, int weight)>> adjList) {
        foreach(var item in adjList) {
            Console.Write($"{item.Key}: ");
            foreach(var node in item.Value) {
                Console.Write($"({node.destination} => {node.weight}), ");
            }

            Console.WriteLine();
        }
    }
}