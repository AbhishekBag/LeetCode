public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> stk = new();

        for(int i = 0; i < n; i++) {
            while(stk.Count() > 0 && temperatures[stk.Peek()] < temperatures[i]) {
                int index = stk.Pop();
                res[index] = i - index;
            }

            stk.Push(i);
        }

        return res;
    }
}