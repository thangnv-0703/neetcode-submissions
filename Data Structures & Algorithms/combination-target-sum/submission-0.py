class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        res = []
        self.backtracking(nums, target, 0, [], res)
        return res
        
    def backtracking(self, nums: List[int], target: int, start_index: int, combination: List[int], res: List):
        if target == 0:
            res.append(combination[:])
            return
        if target < 0:
            return
        for i in range(start_index, len(nums)):
            combination.append(nums[i])
            self.backtracking(nums, target - nums[i], i, combination, res)
            combination.pop()
        