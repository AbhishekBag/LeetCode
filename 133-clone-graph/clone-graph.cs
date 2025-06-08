/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) {
            return null;
        }

        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(node);

        while(q.Count > 0) {
            var dq = q.Dequeue();
            if(!map.ContainsKey(dq)) {
                map[dq] = new Node(dq.val);
            }

            foreach(var neighbor in dq.neighbors) {
                if(!map.ContainsKey(neighbor)) {
                    q.Enqueue(neighbor);
                }
            }
        }

        foreach(var n in map) {
            foreach(var old in n.Key.neighbors) {
                map[n.Key].neighbors.Add(map[old]);
            }
        }

        return map[node];
    }
}