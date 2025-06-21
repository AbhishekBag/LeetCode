public class CustomStack {
    private int topIndex = -1;
    private int capacity = 0;
    private int[] collection;
    public CustomStack(int maxSize) {
        capacity = maxSize;
        collection = new int[capacity];
    }
    
    public void Push(int x) {
        if(topIndex < capacity - 1) {
            collection[++topIndex] = x;
        }
    }
    
    public int Pop() {
        if(topIndex < 0) {
            return -1;
        }

        return collection[topIndex--];
    }
    
    public void Increment(int k, int val) {
        for(int i = 0; i < k && i <= topIndex; i++) {
            collection[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */