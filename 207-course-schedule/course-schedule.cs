public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, int> inDeg = new Dictionary<int, int>();
        Dictionary<int, List<int>> outDeg = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();
        Queue<int> available = new Queue<int>();

        foreach(var item in prerequisites) {
            int item1 = item[0];
            int item2 = item[1];
            if(!inDeg.ContainsKey(item1)) {
                inDeg[item1] = 0;
            }

            inDeg[item1]++;

            if(!outDeg.ContainsKey(item2)) {
                outDeg[item2] = new List<int>();
            }

            outDeg[item2].Add(item1);
        }

        for(int i = 0; i < numCourses; i++) {
            if(!inDeg.ContainsKey(i)) {
                available.Enqueue(i);
            }
        }

        while(available.Count > 0) {
            var cur = available.Dequeue();
            if(!visited.Contains(cur)) {
                visited.Add(cur);
                if(outDeg.ContainsKey(cur)) {
                    foreach(var item in outDeg[cur]) {
                        if(inDeg.ContainsKey(item)) {
                            if(inDeg[item] == 1) {
                                inDeg.Remove(item);
                                available.Enqueue(item);
                            } else {
                                inDeg[item]--;
                            }
                        }
                    }
                }
                
            }
        }

        return visited.Count == numCourses;
    }
}