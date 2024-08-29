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
    ListNode start = null;
    public ListNode ReverseList(ListNode head) {
        if(head == null) {
            return head;
        }

        head = ReverseRecursion(head);
        head.next = null;

        return start;
    }

    private ListNode ReverseRecursion(ListNode node) {
        if(node.next == null) {
            start = node;
            return node;
        }

        var ret = ReverseRecursion(node.next);
        ret.next = node;

        return node;
    }
}