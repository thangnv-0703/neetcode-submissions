class Solution:
    def isValid(self, s: str) -> bool:
        parenthesesMap = {
            ')': '(',
            ']': '[',
            '}': '{'
        }
        stack = []
        for char in s:
            if char not in parenthesesMap:
                stack.append(char)
            else:
                if not stack:
                    return False
                top_element = stack.pop()
                required_opener = parenthesesMap[char]
                if top_element != required_opener:
                    return False
        return not stack