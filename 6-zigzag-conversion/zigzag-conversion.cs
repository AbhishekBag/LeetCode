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
        for(int i = 0; i < s.Length; i++) {
            // Console.WriteLine($"j: {j}; increase: {increase}");
            
            if(increase && j < numRows - 1) {
                arr[j].Add(s[i]);
                j++;
            } else if(increase && j == numRows - 1) {
                arr[j--].Add(s[i]);
                increase = false;
            } else if(!increase && j > 0) {
                arr[j--].Add(s[i]);
            } else if(!increase && j == 0) {
                arr[j++].Add(s[i]);
                increase = true;
            }
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