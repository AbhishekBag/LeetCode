public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> arr = new Dictionary<char, int>();
        int i = 0, j = 0;
        int res = 0, n = s.Length;

        while(i < n && j < n) {
            var cur = s[j];
            while(arr.ContainsKey(cur)) {
                if(arr.ContainsKey(s[i])) {
                    arr.Remove(s[i]);
                }

                i++;
            }
                
            res = Math.Max(res, j - i + 1);            
            arr[cur] = 1;
            j += 1;
        }

        return res;
    }
}

/*
pwwkew

i=2
j=4

arr:
w: 1
k: 1
e: 1



*/