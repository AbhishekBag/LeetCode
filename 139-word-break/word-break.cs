public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        int n = s.Length;
        bool[] arr = new bool[n + 1];
        arr[n] = true;

        for(int i = n - 1; i >= 0; i--) {
            foreach(string word in wordDict) {
                if(IsWordMatch(s, i, word)) {
                    arr[i] = arr[i + word.Length];
                }

                if(arr[i]) {
                    break;
                }
            }
        }

        return arr[0];
    }

    private bool IsWordMatch(string s, int i, string word) {
        var str = s.Substring(i);

        return str.StartsWith(word);
    }
}