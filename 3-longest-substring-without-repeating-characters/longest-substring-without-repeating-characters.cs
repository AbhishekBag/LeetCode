public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> collection = new HashSet<char>();
        int i = 0, j = 0;
        int res = 0, n = s.Length;

        while(j < n) {
            var cur = s[j];
            if(collection.Contains(cur)) {
                collection.Remove(s[i++]);
            } else {
                collection.Add(cur);
                res = Math.Max(res, j - i + 1);
                j++;
            }
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