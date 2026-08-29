public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new ();
    public bool IsWord = false;
}

public class PrefixTree {
    private TrieNode _root;

    public PrefixTree() {
        _root = new TrieNode();
    }
    
    public void Insert(string word) {
        var node = _root;
        foreach(var letter in word)
        {
            if (!node.Children.ContainsKey(letter))
            {
                node.Children[letter] = new TrieNode();
            }
            node = node.Children[letter];
        }
        node.IsWord = true;
    }
    
    public bool Search(string word) {
        var node = _root;
        foreach(var letter in word)
        {
            if (!node.Children.ContainsKey(letter))
            {
                return false;
            }
            node = node.Children[letter];
        }
        return node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = _root;
        foreach(var letter in prefix)
        {
            if (!node.Children.ContainsKey(letter))
            {
                return false;
            }
            node = node.Children[letter];
        }
        return true;
    }
}
