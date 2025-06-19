public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<Node> stk = new Stack<Node>();
        int[] res = new int[temperatures.Length];

        stk.Push(new Node(temperatures[0], 0));
        for(int i = 1; i < temperatures.Length; i++) {
            while(stk.Count > 0 && stk.Peek().temp < temperatures[i]) {
                var ind = stk.Pop().index;
                res[ind] = i - ind;
            }
            
            stk.Push(new Node(temperatures[i], i));
        }

        while(stk.Count > 0) {
            res[stk.Pop().index] = 0;
        }

        return res;
    }
}

public class Node {
    public int temp;
    public int index;
    public Node(int t, int i) {
        temp = t;
        index = i;
    }
}