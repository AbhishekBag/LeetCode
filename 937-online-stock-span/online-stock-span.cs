public class StockSpanner {
    private Stack<Node> stack;
    public StockSpanner() {
        stack = new ();
    }
    
    public int Next(int price) {
        int span = 1;
        while(stack.Count() > 0 && stack.Peek().price <= price) {
            span += stack.Pop().span;
        }

        stack.Push(new Node(price, span));

        return span;
    }
}

public class Node {
    public int price;
    public int span;

    public Node(int _p, int _s) {
        price = _p;
        span = _s;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */