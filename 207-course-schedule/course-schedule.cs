public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, int> indeg = new Dictionary<int, int>();
        Dictionary<int, List<int>> outdeg = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();
        Queue<int> available = new Queue<int>();

        foreach(var item in prerequisites) {
            int i = item[0];
            int j = item[1];

            if(indeg.ContainsKey(i)) {
                indeg[i]++;
            } else {
                indeg[i] = 1;
            }

            if(outdeg.ContainsKey(j)) {
                outdeg[j].Add(i);
            } else {
                outdeg[j] = new List<int> () { i };
            }
        }

        for(int course = 0; course < numCourses; course++) {
            if(!indeg.ContainsKey(course)) {
                available.Enqueue(course);
            }
        }

        while(available.Count() > 0) {
            var course = available.Dequeue();
            if(!visited.Contains(course)) {
                visited.Add(course);
                if(outdeg.ContainsKey(course)) {
                    foreach(var item in outdeg[course]) {
                        if(indeg.ContainsKey(item)) {
                            indeg[item]--;
                            if(indeg[item] == 0) {
                                available.Enqueue(item);
                                // indeg.Remove(item);
                            }
                        }
                    }
                }
            }
        }

        return visited.Count() == numCourses ? true : false;
    }
}