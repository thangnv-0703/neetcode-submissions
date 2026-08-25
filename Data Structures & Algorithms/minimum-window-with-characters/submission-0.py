from collections import defaultdict

class Solution:
    def minWindow(self, s: str, t: str) -> str:
        target_freq = defaultdict(int)
        window_freq = defaultdict(int)
        for character in t:
            target_freq[character] = target_freq[character] + 1
        matched_char = 0
        left = 0
        start_index = -1
        min_len = float('inf')
        for right, char in enumerate(s):
            window_freq[char] += 1
            if char in target_freq and window_freq[char] <= target_freq[char]:
                matched_char += 1

            while matched_char == len(t):
                current_window_size = right - left + 1
                if current_window_size < min_len:
                    start_index = left
                    min_len = current_window_size

                left_char = s[left]
                if left_char in target_freq and window_freq[left_char] <= target_freq[left_char]:
                    matched_char -= 1
                window_freq[left_char] -= 1
                left += 1
        return "" if start_index == -1 else s[start_index: start_index + min_len]