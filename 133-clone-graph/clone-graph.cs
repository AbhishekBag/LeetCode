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
        
        Dictionary<Node, Node> collection = new Dictionary<Node, Node>();
        Queue<Node> q = new Queue<Node>();

        q.Enqueue(node);
        while(q.Count > 0) {
            var dq = q.Dequeue();
            if(!collection.ContainsKey(dq)) {
                collection[dq] = new Node(dq.val);
            }

            foreach(var neighbor in dq.neighbors) {
                if(!collection.ContainsKey(neighbor))
                    q.Enqueue(neighbor);
            }
        }

        foreach(var item in collection) {
            foreach(var old in item.Key.neighbors) {
                collection[item.Key].neighbors.Add(collection[old]);
            }
        }

        return collection[node];
    }
}