public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        int[] sArr = new int[26];

        for(int i = 0; i < s.Length; i++) {
            sArr[s[i] - 'a']++;
            sArr[t[i] - 'a']--;
        }

        foreach(int val in sArr) {
            if(val != 0) {
                return false;
            }
        }

        return true;
    }
}