public class Solution {
    public int MinOperations(string[] logs) {
        Stack<string> stk = new Stack<string>();

        foreach(var operation in logs) {
            if(operation == "../") {
                if(stk.Count() > 0) {
                    stk.Pop();
                }
            }

            if(operation == "./") {
                continue;
            }

            if(!operation.StartsWith('.')) {
                var childFolder = operation.Split()[0];
                stk.Push(childFolder);
            }
        }

        return stk.Count();
    }
}