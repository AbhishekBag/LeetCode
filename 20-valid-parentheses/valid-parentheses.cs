public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        char item = s[0];
        stk.Push(item);
        for(int i = 1; i < s.Length; i++) {
            item = s[i];
            if(item == '(' || item == '{' || item == '[') {
                stk.Push(item);
            } else {
                if(stk.Count() > 0) {
                    char poped = stk.Pop();
                    if(poped == '(' && item == ')' ||
                    poped == '{' && item == '}' ||
                    poped == '[' && item == ']') {
                        continue;
                    }

                    return false;
                }

                return false;
            }            
        }

        if(stk.Count() > 0) {
            return false;
        }

        return true;
    }
}