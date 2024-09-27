public class Trie {
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
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
        var tmp = root;
        foreach(char c in word) {
            if(tmp.node[c - 'a'] == null) {
                return false;
            }

            tmp = tmp.node[c - 'a'];
        }

        return tmp.isWord;
    }
    
    public bool StartsWith(string prefix) {
        var tmp = root;
        foreach(char c in prefix) {
            if(tmp.node[c - 'a'] == null) {
                return false;
            }

            tmp = tmp.node[c - 'a'];
        }

        return true;
    }
}

public class TrieNode {
    public TrieNode[] node;
    public bool isWord;

    public TrieNode(bool iWord = false) {
        node = new TrieNode[26];
        isWord = iWord;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */