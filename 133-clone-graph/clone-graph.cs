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
        HashSet<Node> visited = new HashSet<Node>();
        q.Enqueue(node);

        while(q.Count > 0) {
            Node dq = q.Dequeue();

            if(!visited.Contains(dq)) {
                visited.Add(dq);
                if(!collection.ContainsKey(dq)) {
                    collection[dq] = new Node(dq.val);
                }

                foreach(var neighbor in dq.neighbors) {
                    q.Enqueue(neighbor);
                }
            }            
        }

        q.Enqueue(node);
        visited.Clear();
        while(q.Count > 0) {
            var dq = q.Dequeue();
            if(!visited.Contains(dq)) {
                visited.Add(dq);
                foreach(var neighbor in dq.neighbors) {
                    collection[dq].neighbors.Add(collection[neighbor]);
                    q.Enqueue(neighbor);
                }
            }            
        }

        return collection[node];
    }
}