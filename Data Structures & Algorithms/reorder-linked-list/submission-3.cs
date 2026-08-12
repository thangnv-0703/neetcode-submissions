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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
        {
            return;
        }
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next!= null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        ListNode prev = null;
        slow.next = null;
        while (second != null)
        {
            var nextNode = second.next;
            second.next = prev;
            prev = second;
            second = nextNode;
        }

        ListNode first = head;
        second = prev;
        while (second != null)
        {
            var next1 = first.next;
            var next2 = second.next;
            first.next = second;
            second.next = next1;
            first = next1;
            second = next2;
        }
    }
}
