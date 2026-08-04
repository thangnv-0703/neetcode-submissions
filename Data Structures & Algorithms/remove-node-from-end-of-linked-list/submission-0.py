# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        dump = ListNode(-1)
        dump.next = head
        slow = fast = dump
        for _ in range(n):
            fast = fast.next
            if not fast:
                return head
        while fast.next:
            fast = fast.next
            slow = slow.next
        slow.next = slow.next.next
        return dump.next
