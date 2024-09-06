public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] arr = new bool[s.Length + 1];
        arr[s.Length] = true;

        for(int i = s.Length - 1; i >= 0; i--) {
            foreach(string word in wordDict) {
                if(WordMatch(s, i, word)) {
                    arr[i] = arr[i + word.Length];
                }

                if(arr[i]) {
                    break;
                }
            }
        }

        return arr[0];
    }

    private bool WordMatch(string s, int i, string word) {
        string str = s.Substring(i);

        return str.StartsWith(word);
    }
}

/*
0 1 2 3 4 5 6 7 8
l e e t c o d e True

0 1 2 3
c o d e
*/