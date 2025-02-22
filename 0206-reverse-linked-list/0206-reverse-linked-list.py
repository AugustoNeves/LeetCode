# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, curr: Optional[ListNode]) -> Optional[ListNode]:
        prev = None
        while curr:
            next_node = curr.next #store the next reference
            curr.next = prev #revert the point of curr.next to prev (prev) <- (curr.next)
            prev = curr #update prev with cur () <- (prev) -> (curr)
            curr = next_node #update curr with next   () <- (prev) -> (curr)

        return prev
