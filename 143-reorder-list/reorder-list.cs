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
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode cur = slow.next;
        slow.next = null;
        Stack<ListNode> stk = new Stack<ListNode>();
        while(cur != null) {
            stk.Push(cur);
            cur = cur.next;
        }

        ListNode tmp = head;
        while(stk.Count() > 0) {
            var poped = stk.Pop();
            poped.next = tmp.next;
            tmp.next = poped;
            tmp = poped.next;
        }
    }
}