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

    private bool SearchNode(TrieNode root, string word, int i) {
        if(i == word.Length) {
            return root.isWord;
        }

        var c = word[i];
        if(c == '.') {
            for(int j = 0; j < 26; j++) {
                if(root.node[j] != null) {
                    if(SearchNode(root.node[j], word, i + 1)) {
                        return true;
                    }
                }
            }

            return false;
        } else {
            if(root.node[c - 'a'] == null) {
                return false;
            }

            return SearchNode(root.node[c - 'a'], word, i + 1);
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