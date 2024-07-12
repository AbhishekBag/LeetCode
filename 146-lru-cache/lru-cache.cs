public class LRUCache {
    private int capacity;
    private Dictionary<int, DNode> map;
    private DList priorityList;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        map = new Dictionary<int, DNode>();
        priorityList = new DList();
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)) {
            priorityList.MoveFirst(map[key]);
            return map[key].val;
        }

        return -1;
    }
    
    public void Put(int key, int value) {
        if(!map.ContainsKey(key)) {
            var node = new DNode(value, key);
            priorityList.AddFirst(node);
            map[key] = node;

            if(map.Count > capacity) {
                var removed = priorityList.RemoveLast();
                if(map.ContainsKey(removed.key)) {
                    map.Remove(removed.key);
                }                
            }
        } else {
            map[key].val = value;
            priorityList.MoveFirst(map[key]);
        }
    }
}

public class DList {
    private DNode head;
    private DNode tail;

    public DList() {
        head = new DNode(-1, -1);
        tail = new DNode(-1, -1);

        head.next = tail;
        tail.prev = head;
    }

    public void AddFirst(DNode node) {
        var next = head.next;
        node.next = next;
        node.prev = head;
        next.prev = node;
        head.next = node;
    }

    public DNode RemoveLast() {
        return Remove(tail.prev);
    }

    public DNode Remove(DNode node) {
        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;

        return node;
    }

    public void MoveFirst(DNode node) {
        Remove(node);
        AddFirst(node);
    }
}

public class DNode {
    public int key;
    public int val;
    public DNode next;
    public DNode prev;

    public DNode(int v, int k) {
        val = v;
        key = k;
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