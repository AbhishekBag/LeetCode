public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> res = new List<int>();
        Dictionary<int, HashSet<int>> inDeg = new Dictionary<int, HashSet<int>>();
        Dictionary<int, HashSet<int>> outDeg = new Dictionary<int, HashSet<int>>();
        Queue<int> available = new Queue<int>();

        foreach(var item in prerequisites) {
            var course = item[0];
            var prerequisite = item[1];

            if(!inDeg.ContainsKey(course)) {
                inDeg[course] = new HashSet<int>();
            }
            inDeg[course].Add(prerequisite);

            if(!outDeg.ContainsKey(prerequisite)) {
                outDeg[prerequisite] = new HashSet<int>();
            }
            outDeg[prerequisite].Add(course);
        }

        for(int i = 0; i < numCourses; i++) {
            if(!inDeg.ContainsKey(i)) {
                available.Enqueue(i);
            }
        }

        while(available.Count > 0) {
            var cur = available.Dequeue();
            res.Add(cur);

            if(outDeg.ContainsKey(cur)) {
                var possibleCourses = outDeg[cur];
                foreach(var pC in possibleCourses) {
                    if(inDeg.ContainsKey(pC)) {
                        if(inDeg[pC].Count == 1) {
                            available.Enqueue(pC);
                            inDeg.Remove(pC);
                        } else {
                            inDeg[pC].Remove(cur);
                        }
                    }
                }
            }
        }

        return res.Count == numCourses ? res.ToArray() : new int[]{};
    }
}