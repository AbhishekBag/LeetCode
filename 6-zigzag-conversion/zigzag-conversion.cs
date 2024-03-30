public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1) {
            return s;
        }

        List<char>[] arr = new List<char>[numRows];
        for(int i = 0; i < numRows; i++) {
            arr[i] = new List<char>();
        }

        int j = 0;
        bool increase = true;
        int incr = 1;
        int curRow = 0;
        for(int i = 0; i < s.Length; i++) {
            arr[curRow].Add(s[i]);
            if(curRow == 0) {
                incr = 1;
            }

            if(curRow == numRows - 1) {
                incr = -1;
            }

            curRow += incr;
        }
        // Console.WriteLine("aa");

        StringBuilder sb = new StringBuilder();
        foreach(var lst in arr) {
            foreach(char c in lst) {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}