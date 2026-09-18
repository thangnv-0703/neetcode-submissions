class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        max_sum = current_sum = nums[0]
        for num in nums[1:]:
            if current_sum + num > num:
                current_sum += num
            else:
                current_sum = num
            max_sum = max(current_sum, max_sum)
        return max_sum