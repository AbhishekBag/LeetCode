public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, Node> collection = new Dictionary<int, Node>();
        foreach(var num in nums) {
            if(!collection.ContainsKey(num)) {
                collection[num] = new Node(num);
            }

            int l = num - 1;
            int m = num + 1;
            if(collection.ContainsKey(l)) {
                collection[num].less = collection[l];
                collection[l].more = collection[num];
            }

            if(collection.ContainsKey(m)) {
                collection[num].more = collection[m];
                collection[m].less = collection[num];
            }
        }

        
        HashSet<int> visited = new HashSet<int>();
        int maxCount = 0;
        foreach(var num in nums) {
            int count = 0;
            count = CountChain(collection, num, visited);

            maxCount = Math.Max(maxCount, count);
        }
        
        return maxCount;
    }

    private int CountChain(Dictionary<int, Node> collection, int num, HashSet<int> visited) {
        if(!collection.ContainsKey(num) || visited.Contains(num)) {
            return 0;
        }

        visited.Add(num);

        return 1 + CountChain(collection, num - 1, visited) + CountChain(collection, num + 1, visited);
    }
}

public class Node {
    public int val;
    public Node less;
    public Node more;
    public Node(int _v, Node _l = null, Node _m = null) {
        val = _v;
        less = _l;
        more = _m;
    }
}