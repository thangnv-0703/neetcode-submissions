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
    public ListNode MergeKLists(ListNode[] lists) {
        var heap = new PriorityQueue<ListNode, int>();
        var dummy = new ListNode();
        var tail = dummy;
        foreach(var node in lists)
        {
            if (node != null)
            {
                heap.Enqueue(node, node.val);
            }
        }
        while (heap.Count > 0)
        {
            var node = heap.Dequeue();
            tail.next = node;
            tail = tail.next;
            if (node.next != null)
            {
                heap.Enqueue(node.next, node.next.val);
            } 
        }
        return dummy.next;
    }
}
