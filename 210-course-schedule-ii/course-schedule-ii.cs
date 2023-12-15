public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
        Dictionary<int, int> indeg = new Dictionary<int, int>();
        Queue<int> q = new Queue<int>();
        List<int> res = new List<int>();

        for(int i = 0; i < numCourses; i++) {
            indeg.Add(i, 0);
        }

        foreach(var edge in prerequisites) {
            int src = edge[1];
            int dest = edge[0];
            if(adjList.ContainsKey(src)) {
                adjList[src].Add(dest);
            } else {
                var newList = new List<int>();
                newList.Add(dest);
                adjList.Add(src, newList);
            }

            if(indeg.ContainsKey(dest)) {
                indeg[dest]++;
            }
            // else {
            //     indeg.Add(dest, 1);
            // }
        }

        ScanIndeg(indeg, q);
        // DisplayIndeg(indeg);
        // DisplayAdjList(adjList);

        while(q.Count() > 0) {
            // DisplayQ(q);
            var pop = q.Dequeue();
            // Console.WriteLine($"poped: {pop}");
            res.Add(pop);
            if(adjList.ContainsKey(pop)) {
                foreach(var item in adjList[pop]) {
                    indeg[item]--;
                    if(indeg[item] == 0) {
                        q.Enqueue(item);
                    }
                }
            }
        }

        if(res.Count() == numCourses) {
            return res.ToArray();
        }

        return new int[0];
    }

    private void ScanIndeg(Dictionary<int, int> indeg, Queue<int> q) {
        foreach(var item in indeg) {
            if(item.Value == 0) {
                q.Enqueue(item.Key);
            }
        }
    }

    private void DisplayIndeg(Dictionary<int, int> indeg) {
        Console.WriteLine("Indegree List:");
        foreach(var item in indeg) {
            Console.WriteLine($"key: {item.Key}: {item.Value}");
        }

        Console.WriteLine();
    }

    private void DisplayAdjList(Dictionary<int, List<int>> adjList) {        
        Console.WriteLine("Adj List:");
        foreach(var item in adjList) {
            Console.Write($"src: {item.Key}: ");
            foreach(var dst in item.Value) {
                Console.Write($"{dst},");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        
        Console.WriteLine();
    }

    private void DisplayQ(Queue<int> q) {
        Console.WriteLine("Queue Contains:");
        foreach(var item in q) {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine();
    }
}