public class LRUCache {
    private ListNode head;
    private ListNode last;
    private int c;
    private Dictionary<int, ListNode> map;
    public LRUCache(int capacity) {
        c = capacity;
        map = new();
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)) {
            var node = map[key];
            int val = node.val;

            AlterNode(node);

            return val;
        }

        return -1;
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            var node = map[key];
            node.val = value;
            AlterNode(node);
        } else {
            if (map.Count >= c) {
                RemoveLast();
            }

            var node = new ListNode(key, value);
            AddFirst(node);
            map[key] = node;
        }
    }

    private void RemoveLast() {
        if (last == null) return;

        var node = last;
        if (head == last) {
            head = null;
            last = null;
        } else {
            last = last.prev;
            last.next = null;
        }

        if (map.ContainsKey(node.key)) {
            map.Remove(node.key);
        }
    }

    private void AlterNode(ListNode node) {
        if(node == head) {
            return;
        }
        if(node == last) {
            last = node.prev;
            last.next = null;
            AddFirst(node);
            return;
        }

        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;

        AddFirst(node);
    }

    private void AddFirst(ListNode node) {
        node.next = null;
        node.prev = null;

        if(head == null) {
            head = node;
            last = node;
            return;
        }

        node.next = head;
        head.prev = node;

        head = node;
    }
}

public class ListNode {
    public int key;
    public int val;
    public ListNode next;
    public ListNode prev;

    public ListNode(int k, int v) {
        key = k;
        val = v;
        next = null;
        prev = null;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */