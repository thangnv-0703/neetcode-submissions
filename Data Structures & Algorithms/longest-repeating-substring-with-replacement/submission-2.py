class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        freq = {}
        highest_freq = 0
        left = right = 0
        length_longest_substr = 0
        while right < len(s):
            freq[s[right]] = freq.get(s[right], 0) + 1
            highest_freq = max(highest_freq, freq[s[right]])
            window_length = right - left + 1
            num_char_to_replace = window_length - highest_freq
            if num_char_to_replace <= k:
                length_longest_substr = window_length
            else:
                freq[s[left]] = freq.get(s[left], 0) - 1
                left += 1
            right += 1
        return length_longest_substr