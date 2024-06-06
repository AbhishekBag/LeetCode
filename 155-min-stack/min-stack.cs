public class MinStack {
    Stack<StackNode> myStack;

    public MinStack() {
        myStack = new Stack<StackNode>();
    }
    
    public void Push(int val) {
        if(myStack.Count() == 0) {
            myStack.Push(new StackNode(val, val));
        } else {
            if(val > GetMin()) {
                myStack.Push(new StackNode(val, GetMin()));
            } else {
                myStack.Push(new StackNode(val, val));
            }            
        }
    }
    
    public void Pop() {
        myStack.Pop();
    }
    
    public int Top() {
        return myStack.Peek().val;
    }
    
    public int GetMin() {
        return myStack.Peek().min;
    }
}

public class StackNode {
    public int val;
    public int min;

    public  StackNode(int v, int m) {
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