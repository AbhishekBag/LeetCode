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
        if(n == 0 || head == null || head.next == null) {
            return null;
        }

        var tmp = head;
        while(n > 0) {
            tmp = tmp.next;
            n--;
        }

        // if(tmp == null) {
        //     return null;
        // }

        var tmp1 = head;
        ListNode prev = null;
        while(tmp != null) {
            tmp = tmp.next;
            prev = tmp1;
            tmp1 = tmp1.next;
        }

        if(prev != null) {
            prev.next = tmp1.next;
        } else {
            head = head.next;
        }
        

        return head;
    }
}