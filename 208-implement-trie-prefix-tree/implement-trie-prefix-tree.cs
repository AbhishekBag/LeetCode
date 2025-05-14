public class Trie {
    private TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        var tmp = root;

        foreach(char c in word) {
            int i = c - 'a';
            if(tmp.node[i] == null) {
                tmp.node[i] = new TrieNode();
            }
            
            tmp = tmp.node[i];
        }

        tmp.isWord = true;
    }
    
    public bool Search(string word) {
        var tmp = root;

        foreach(char c in word) {
            int i = c - 'a';
            if(tmp.node[i] == null) {
                return false;
            }

            tmp = tmp.node[i];
        }

        return tmp.isWord;
    }
    
    public bool StartsWith(string prefix) {
        var tmp = root;

        foreach(char c in prefix) {
            int i = c - 'a';
            if(tmp.node[i] == null) {
                return false;
            }

            tmp = tmp.node[i];
        }

        return true;        
    }
}

public class TrieNode {
    public TrieNode[] node;
    public bool isWord;

    public TrieNode(bool _isWord = false) {
        node = new TrieNode[26];
        isWord = _isWord;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */