public class MinStack {
    private Stack<Node> stack;
    public MinStack() {
        stack = new();
    }
    
    public void Push(int val) {
        if(stack.Count() == 0) {
            stack.Push(new Node(val, val));
        } else {
            var peeked = stack.Peek();
            stack.Push(new Node(val, Math.Min(val, peeked.min)));
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        var peeked = stack.Peek();
        return peeked.val;
    }
    
    public int GetMin() {
        var peeked = stack.Peek();
        return peeked.min;
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