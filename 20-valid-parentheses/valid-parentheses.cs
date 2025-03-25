public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        foreach(char c in s) {
            if(c == '(' || c == '{' || c == '[') {
                stk.Push(c);
            } else if(stk.Count > 0) {
                char peek = stk.Peek();
                if(peek == '(' && c == ')' || peek == '{' && c == '}' || peek =='[' && c == ']') {
                    stk.Pop();
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        return stk.Count == 0 ? true : false;
    }
}