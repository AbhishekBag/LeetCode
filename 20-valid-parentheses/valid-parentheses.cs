public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        foreach(char c in s) {
            if(c == '(' || c == '{' || c == '[') {
                stk.Push(c);
            } else if(stk.Count != 0) {
                char p = stk.Peek();
                if(p == '(' && c == ')' ||
                p == '{' && c == '}' ||
                p == '[' && c == ']') {
                    stk.Pop();
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        if(stk.Count == 0) {
            return true;
        }

        return false;
    }
}