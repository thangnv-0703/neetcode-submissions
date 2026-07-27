class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        result = []
        nums.sort()
        for idx, item in enumerate(nums):
            if idx > 0 and item == nums[idx - 1]:
                continue
            left, right = idx + 1, len(nums) - 1
            while left < right:
                currentSum = item + nums[left] + nums[right]
                if currentSum < 0:
                    left += 1
                elif currentSum > 0:
                    right -= 1
                else:
                    result.append([item, nums[left], nums[right]])
                    left += 1
                    right -= 1
                    while left < right and nums[left] == nums[left-1]:
                        left += 1
        return result
