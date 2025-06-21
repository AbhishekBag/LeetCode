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
    private ListNode ref1 = null;
    private bool res = true;
    public bool IsPalindrome(ListNode head) {
        ref1 = head;
        PrintReverse(head);
        return res;
    }

    private void PrintReverse(ListNode node) {
        if(node == null) {
            return;
        }

        PrintReverse(node.next);

        if(ref1.val != node.val) {
            res = false;
            return;
        }

        ref1 = ref1.next;
    }
}