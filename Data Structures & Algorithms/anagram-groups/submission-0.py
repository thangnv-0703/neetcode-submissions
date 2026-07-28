from collections import defaultdict

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        n = len(strs)
        word_map = defaultdict(list)
        for word in strs:
            word_key = [0] * 26
            for letter in word:
                word_key[ord('z') - ord(letter)] += 1
            word_map[tuple(word_key)].append(word)
        return list(word_map.values())