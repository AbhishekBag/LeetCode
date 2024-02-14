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
        if(head == null || n == 0) {
            return head;
        }
        
        var tmp = head;
        while(tmp != null && n != 0) {
            tmp = tmp.next;
            n--;
        }

        if(tmp == null) {
            return head.next;
        }

        var prev = head;
        var next = head;

        while(tmp != null) {
            prev = next;
            next = next.next;
            tmp = tmp.next;
        }

        prev.next = next.next;

        return head;
    }
}