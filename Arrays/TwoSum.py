from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        myDict = {}
        for i,n in enumerate(nums):
            diff = target - n
            if diff in myDict:
                return [myDict[diff], i]
            myDict[n] = i;
        

nums = [2,7,11,15]
target = 9

result = Solution()
print(result.twoSum(nums, target))