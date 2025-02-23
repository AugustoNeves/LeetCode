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
    public ListNode MiddleNode(ListNode head) {
        ListNode ahead = head;

        while(ahead != null && ahead.next != null){
            ahead = ahead.next.next;
            head = head.next;
        }

        return head;
    }
}