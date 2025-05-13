public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        int[] collection = new int[26];
        for(int i = 0; i < s.Length; i++) {
            collection[s[i] - 'a']++;
            collection[t[i] - 'a']--;
        }

        foreach(int item in collection) {
            if(item != 0) {
                return false;
            }
        }

        return true;
    }
}