public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, HashSet<int>> inboundMap = new Dictionary<int, HashSet<int>>();
        Dictionary<int, HashSet<int>> outBoundMap = new Dictionary<int, HashSet<int>>();
        Queue<int> q = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        for(int i = 0; i < numCourses; i++) {
            inboundMap[i] = new HashSet<int>();
        }

        foreach(var item in prerequisites) {
            var course = item[0];
            var prerequisite = item[1];

            inboundMap[course].Add(prerequisite);

            if(!outBoundMap.ContainsKey(prerequisite)) {
                outBoundMap[prerequisite] = new HashSet<int>();
            }

            outBoundMap[prerequisite].Add(course);
        }

        foreach(var item in inboundMap) {
            if(item.Value.Count == 0) {
                q.Enqueue(item.Key);
            }
        }

        while(q.Count > 0) {
            var current = q.Dequeue();
            if(!visited.Contains(current)) {
                visited.Add(current);
                if(outBoundMap.ContainsKey(current)) {
                    foreach(var item in outBoundMap[current]) {
                        // if(inboundMap.ContainsKey(item)) {
                            if(inboundMap[item].Count == 1) {
                                q.Enqueue(item);
                                inboundMap.Remove(item);
                            } else {
                                inboundMap[item].Remove(current);
                            }
                        // }
                    }
                }                
            }            
        }

        return visited.Count == numCourses;
    }
}