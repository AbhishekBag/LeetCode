/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null) {
            return null;
        }

        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node tmp = head;

        while(tmp != null) {
            if(!map.ContainsKey(tmp)) {
                map[tmp] = new Node(tmp.val);
            }

            tmp = tmp.next;
        }

        tmp = head;
        while(tmp != null) {
            if(tmp.next != null) {
                map[tmp].next = map[tmp.next];
            } else {
                map[tmp].next = null;
            }

            if(tmp.random != null) {
                map[tmp].random = map[tmp.random];
            } else {
                map[tmp].random = null;
            }

            tmp = tmp.next;
        }

        return map[head];
    }
}