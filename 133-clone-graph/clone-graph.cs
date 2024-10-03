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
        collection[node] = new Node(node.val);

        while(q.Count > 0) {
            Node dq = q.Dequeue();            
            foreach(var neighbor in dq.neighbors) {                
                if(!collection.ContainsKey(neighbor)) {
                    collection[neighbor] = new Node(neighbor.val);
                    q.Enqueue(neighbor);
                }

                collection[dq].neighbors.Add(collection[neighbor]);
            }
        }

        return collection[node];
    }
}