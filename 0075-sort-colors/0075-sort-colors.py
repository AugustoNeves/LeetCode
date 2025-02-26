class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        l,r = 0, len(nums) - 1
        i = 0

        def swap(i,j):
            tmp = nums[i]
            nums[i] = nums[j]
            nums[j] = tmp

        while i<= r:
            if nums[i] == 0:
                swap(l, i)
                l += 1
            elif nums[i] == 2:
                swap(i, r)
                r -= 1
                i -= 1
            i += 1

# Follow up: Could you come up with a one-pass algorithm using only constant extra space?
# 1)- use three pointers one for left end , one for right end and one for iteration.
# 2)-if you see 0 swap it with left pointer and increase the left pointer by one.
# 3)-if you see 2 swap it with right pointer and decrease right pointer by one.
# 4)-else increase the iterating pointer.
# 5)-run this loop while the iterating pointer<=right pointer.
# right pointer=n-1
# left pointer=0
# iterating pointer =0 runs while it is<=right pointer.