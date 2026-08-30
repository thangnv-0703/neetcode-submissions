public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new();
    public bool IsWord = false;
}

public class WordDictionary {
    private TrieNode _root;
    public WordDictionary() {
        _root = new TrieNode();
    }
    
    public void AddWord(string word) 
    {
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
    
    public bool Search(string word) 
    {
        return SearchHelper(word, 0, _root);
    }

    private bool SearchHelper(string word, int wordIndex, TrieNode node)
    {
        for(var i = wordIndex; i < word.Length; i++)
        {
            var letter = word[i];
            if (letter == '.')
            {
                foreach(var childNode in node.Children.Values)
                {
                    if (SearchHelper(word, i + 1, childNode))
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (node.Children.ContainsKey(letter))
            {
                node =  node.Children[letter];
            }
            else
            {
                return false;
            }
        }
        return node.IsWord;
    }
}

