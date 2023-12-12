public class WordDictionary {
    public int size = 26;
    public WordDictionary[] root;
    public bool isEnd;

    public WordDictionary() {
        root = new WordDictionary[size];
        isEnd = false;
    }

    public void AddWord(string word) {
        WordDictionary tr = this;
        foreach (char c in word) {
            if (tr.root[c - 'a'] == null) {
                tr.root[c - 'a'] = new WordDictionary();
            }
            tr = tr.root[c - 'a'];
        }
        tr.isEnd = true;
    }

    // public bool Search(string word) {
    //     return SearchWord(word, 0, this);
    // }

    public bool Search(string word) {
    List<WordDictionary> nodes = new List<WordDictionary>();
    nodes.Add(this);

    for (int i = 0; i < word.Length; i++) {
        char c = word[i];
        List<WordDictionary> nextNodes = new List<WordDictionary>();

        foreach (WordDictionary node in nodes) {
            if (c == '.') {
                foreach (WordDictionary child in node.root) {
                    if (child != null) {
                        nextNodes.Add(child);
                    }
                }
            } else if (node.root[c - 'a'] != null) {
                nextNodes.Add(node.root[c - 'a']);
            }
        }

        nodes = nextNodes;
        if (nodes.Count == 0) {
            return false;
        }
    }

    foreach (WordDictionary node in nodes) {
        if (node.isEnd) {
            return true;
        }
    }

    return false;
}

    private bool SearchWord(string word, int index, WordDictionary node) {
        if (index == word.Length) {
            return node.isEnd;
        }

        char c = word[index];
        if (c == '.') {
            for (int j = 0; j < size; j++) {
                if (node.root[j] != null && SearchWord(word, index + 1, node.root[j])) {
                    return true;
                }
            }
            return false;
        } else {
            if (node.root[c - 'a'] == null) {
                return false;
            }
            return SearchWord(word, index + 1, node.root[c - 'a']);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */