class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        n = len(nums)
        left_product = [1] * n
        right_product = [1] * n
        for i in range(1, n):
            left_product[i] = left_product[i - 1] * nums[i - 1]
        for j in range(n - 2, -1, -1):
            right_product[j] = right_product[j + 1] * nums[j + 1]
        output = [1] * n
        for k in range(n):
            output[k] = left_product[k] * right_product[k]
        return output