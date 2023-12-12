public class Trie {

    public Trie[] root;
    public bool isEnd;

    public Trie() {
        root = new Trie[26];
        isEnd = false;
    }
    
    public void Insert(string word) {
        Trie[] cur = root;
        var tr = this;
        foreach(char c in word) {
            if(cur[c - 'a'] != null) {
                tr = cur[c - 'a'];
                cur = tr.root;
            } else {
                tr = new Trie();
                cur[c - 'a'] = tr;
                cur = tr.root;
            }
        }

        tr.isEnd = true;
    }
    
    public bool Search(string word) {
        var cur = root;
        var tr = this;
        foreach(char c in word) {
            if(cur[c - 'a'] != null) {
                tr = cur[c - 'a'];
                cur = tr.root;
            } else {
                return false;
            }
        }

        return tr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        var cur = root;
        var tr = this;
        foreach(char c in prefix) {
            if(cur[c - 'a'] != null) {
                tr = cur[c - 'a'];
                cur = tr.root;
            } else {
                return false;
            }
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