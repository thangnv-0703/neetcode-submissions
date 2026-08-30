class TrieNode:
    def __init__(self):
        self.is_word = False
        self.children = {}

class WordDictionary:
    def __init__(self):
        self.root = TrieNode()

    def addWord(self, word: str) -> None:
        cur = self.root
        for letter in word:
            if letter not in cur.children:
                cur.children[letter] = TrieNode()
            cur = cur.children[letter]
        cur.is_word = True

    def search(self, word: str) -> bool:
        return self.search_helper(word, 0, self.root)
        
    def search_helper(self, word: str, word_index: int, cur_node: TrieNode) -> bool:
        for i in range(word_index, len(word)):
            letter = word[i]
            if letter == '.':
                for child in cur_node.children.values():
                    if self.search_helper(word, i + 1, child):
                        return True
                return False
            elif letter in cur_node.children:
                cur_node = cur_node.children[letter]
            else: 
                return False
        return cur_node.is_word