public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk = new Stack<int>();

        foreach(var token in tokens) {
            if(Int32.TryParse(token, out int num)) {
                stk.Push(num);
            } else {
                if(stk.TryPop(out int num1) && stk.TryPop(out int num2)) {
                    switch (token) {
                        case "+":
                            stk.Push(num2 + num1);
                            break;
                        case "-":
                            stk.Push(num2 - num1);
                            break;
                        case "*":
                            stk.Push(num2 * num1);
                            break;
                        case "/":
                            stk.Push(num2 / num1);
                            break;
                    }
                } else {
                    return 0;
                }
            }
        }

        return stk.Pop();
    }
}