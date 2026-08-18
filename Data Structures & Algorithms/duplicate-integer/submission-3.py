class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        hashed = set()
        for num in nums:
            if num in hashed:
                return True
            hashed.add(num)
        return False