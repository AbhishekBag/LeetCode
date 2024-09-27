public class WordDictionary {
    private TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var tmp = root;
        foreach(char c in word) {
            if(tmp.node[c - 'a'] == null) {
                tmp.node[c - 'a'] = new TrieNode();
            }

            tmp = tmp.node[c - 'a'];
        }

        tmp.isWord = true;
    }
    
    public bool Search(string word) {
        return SearchNode(root, word, 0);
    }

    private bool SearchNode(TrieNode R, string word, int i) {
        // Base case: If we've reached the end of the word, return whether it's a valid word.
        if (i == word.Length) {
            return R.isWord;
        }

        char c = word[i];

        // If current character is '.', check all possible nodes.
        if (c == '.') {
            for (int j = 0; j < 26; j++) {
                if (R.node[j] != null) {
                    // Recursively check the next character after the wildcard
                    if (SearchNode(R.node[j], word, i + 1)) {
                        return true;  // If any path leads to a valid word, return true
                    }
                }
            }
            return false;  // If no valid path is found for the wildcard, return false
        } else {
            // Regular character case
            if (R.node[c - 'a'] == null) {
                return false;  // If there's no matching node, return false
            }
            return SearchNode(R.node[c - 'a'], word, i + 1);  // Continue with the next character
        }
    }

}

public class TrieNode {
    public TrieNode[] node;
    public bool isWord = false;

    public TrieNode() {
        node = new TrieNode[26];
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */