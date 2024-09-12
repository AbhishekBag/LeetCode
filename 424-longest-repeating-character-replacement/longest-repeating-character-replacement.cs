public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        if(n <= k) {
            return n;
        }

        int[] arr = new int[26];
        int res = 1;
        int i = 0, j = 0;
        for(; j < n; j++) {
            arr[s[j] - 'A'] += 1;
            int maxFreq = GetMaxFrequency(arr);
            while(j - i + 1 - maxFreq > k) {
                arr[s[i] - 'A'] -= 1;
                i++;
            }

            res = Math.Max(res, j - i + 1);
        }

        return res;
    }

    private int GetMaxFrequency(int[] arr) {
        int max = Int32.MinValue;
        foreach(int item in arr) {
            max = Math.Max(max, item);
        }

        return max;
    }
}