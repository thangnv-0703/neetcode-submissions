/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(-1);
        dummy.next = head;
        var left = dummy;
        var right = dummy;
        while (n > 0)
        {
            right = right.next;
            n -= 1;
        }
        while (right.next != null)
        {
            right = right.next;
            left = left.next;
        }
        left.next = left.next.next;
        return dummy.next;
    }
}
