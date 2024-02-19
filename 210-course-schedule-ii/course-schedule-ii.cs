public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> res = new List<int>();
        (Dictionary<int, HashSet<int>> inDeg, Dictionary<int, HashSet<int>> outDeg) = GetDegree(prerequisites);
        Queue<int> independentCourses = new Queue<int>();

        for(int i = 0; i < numCourses; i++) {
            if(!inDeg.ContainsKey(i)) {
                independentCourses.Enqueue(i);
            }
        }

        while(independentCourses.Count() > 0) {
            var currentCourse = independentCourses.Dequeue();
            res.Add(currentCourse);

            if(outDeg.ContainsKey(currentCourse)) {
                var possibleCourses = outDeg[currentCourse];
                foreach(var pCourse in possibleCourses) {
                    if(inDeg.ContainsKey(pCourse)) {
                        if(inDeg[pCourse].Count() == 1) {
                            inDeg.Remove(pCourse);
                            independentCourses.Enqueue(pCourse);
                        } else {
                            inDeg[pCourse].Remove(currentCourse);
                        }
                    }                
                }
            }            
        }

        return res.Count() == numCourses ? res.ToArray() : new int[]{};
    }

    private (Dictionary<int, HashSet<int>>, Dictionary<int, HashSet<int>>) GetDegree(int[][] prerequisites) {
        Dictionary<int, HashSet<int>> inDeg = new Dictionary<int, HashSet<int>>();
        Dictionary<int, HashSet<int>> outDeg = new Dictionary<int, HashSet<int>>();
        foreach(var course in prerequisites) {
            var c = course[0];
            var d = course[1];
            if(!inDeg.ContainsKey(c)) {
                inDeg[c] = new HashSet<int>();
            }

            inDeg[c].Add(d);

            if(!outDeg.ContainsKey(d)) {
                outDeg[d] = new HashSet<int>();
            }

            outDeg[d].Add(c);
        }

        return (inDeg, outDeg);
    }

    private void PrintDeg(Dictionary<int, HashSet<int>> deg) {
        foreach(var item in deg) {
            Console.WriteLine(item.Key + ": ");
            foreach(var n in item.Value) {
                Console.Write($"{n}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}