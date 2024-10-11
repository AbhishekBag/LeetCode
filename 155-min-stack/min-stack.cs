public class MinStack {
    private Stack<Node> collection;
    public MinStack() {
        collection = new Stack<Node>();
    }
    
    public void Push(int val) {
        int min = val;
        if(collection.Count > 0) {
            min = GetMin() > val ? val : GetMin();
        }
        
        collection.Push(new Node(val, min));
    }
    
    public void Pop() {
        if(collection.Count > 0) {
            collection.Pop();
        }
    }
    
    public int Top() {
        if(collection.Count > 0) {
            var top = collection.Peek();
            return top.val;
        }

        return -1;
    }
    
    public int GetMin() {
        if(collection.Count > 0) {
            var top = collection.Peek();
            return top.min;
        }

        return -1;
    }
}

public class Node {
    public int val;
    public int min;

    public Node(int v, int m) {
        val = v;
        min = m;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */