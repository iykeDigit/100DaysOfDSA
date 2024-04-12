class Solution(object):
    def containsDuplicate(self, nums):
        newset = set(nums)
        return len(nums) == len(newset)

nums = [1,2,3,1]
solution_instance = Solution()
print(solution_instance.containsDuplicate(nums))