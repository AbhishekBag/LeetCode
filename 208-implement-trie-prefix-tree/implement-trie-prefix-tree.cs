public class Trie {

    private Trie[] node;
    private bool isWord;

    public Trie() {
        node = new Trie[26];
        isWord = false;
    }
    
    public void Insert(string word) {
        Trie root = this;
        foreach(char c in word) {
            if(root.node[c - 'a'] == null) {
                root.node[c - 'a'] = new Trie();
            }

            root = root.node[c - 'a'];
        }

        root.isWord = true;
    }
    
    public bool Search(string word) {
        Trie cur = this;
        foreach(char c in word) {
            if(cur.node[c - 'a'] == null) {
                return false;
            }

            cur = cur.node[c - 'a'];
        }

        return cur.isWord;
    }
    
    public bool StartsWith(string prefix) {
        Trie cur = this;
        foreach(char c in prefix) {
            if(cur.node[c - 'a'] == null) {
                return false;
            }

            cur = cur.node[c - 'a'];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */