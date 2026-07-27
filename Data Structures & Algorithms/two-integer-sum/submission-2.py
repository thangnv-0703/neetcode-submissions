class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hashed = {}
        for i in range(len(nums)):
            complemented_num = target - nums[i]
            if complemented_num in hashed:
                return [hashed[complemented_num], i]
            else:
                hashed[nums[i]] = i
        return [None, None]