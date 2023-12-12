public class Trie {

    public Trie[] root;
    public bool isEnd;

    public Trie() {
        root = new Trie[26];
        isEnd = false;
    }
    
    public void Insert(string word) {
        var tr = this;
        foreach(char c in word) {
            if(tr.root[c - 'a'] == null) {
                tr.root[c - 'a'] = new Trie();
            }
            
            tr = tr.root[c - 'a'];
        }

        tr.isEnd = true;
    }
    
    public bool Search(string word) {
        var tr = this;
        foreach(char c in word) {
            if(tr.root[c - 'a'] == null) {
                return false;
            } else {
                tr = tr.root[c - 'a'];
            }
        }

        return tr.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        var tr = this;
        foreach(char c in prefix) {
            if(tr.root[c - 'a'] == null) {
                return false;
            } else {
                tr = tr.root[c - 'a'];
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