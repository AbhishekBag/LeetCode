/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null) {
            return root;
        }
        
        Queue<QNode> q = new Queue<QNode>();

        QNode prev = new QNode(null);
        q.Enqueue(new QNode(root, 0));

        while(q.Count > 0) {
            QNode cur = q.Dequeue();

            if(prev.node != null && prev.level == cur.level) {
                prev.node.next = cur.node;
            }

            if(cur.node.left != null) {
                q.Enqueue(new QNode(cur.node.left, cur.level + 1));
            }
            if(cur.node.right != null) {
                q.Enqueue(new QNode(cur.node.right, cur.level + 1));
            }
            
            prev = cur;
        }

        return root;
    }
}

public class QNode {
    public Node node;
    public int level;

    public QNode(Node n, int l = 0) {
        node = n;
        level = l;
    }
}