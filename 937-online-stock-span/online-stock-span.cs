public class StockSpanner {
    private Stack<Node> stk;
    public StockSpanner() {
        stk = new Stack<Node>();
    }
    
    public int Next(int price) {
        int span = 1;
        while(stk.Count > 0 && stk.Peek().price <= price) {
            span += stk.Pop().span;
        }

        stk.Push(new Node(price, span));

        return span;
    }
}

public class Node {
    public int price;
    public int span;

    public Node(int p, int s) {
        price = p;
        span = s;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */