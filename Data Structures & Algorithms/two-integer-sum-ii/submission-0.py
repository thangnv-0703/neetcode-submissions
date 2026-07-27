class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        left = 1
        right = len(numbers)
        while left < right:
            currentSum = numbers[left-1] + numbers[right-1]
            if currentSum == target:
                return [left, right]
            elif currentSum < target:
                left += 1
            else: 
                right -= 1
