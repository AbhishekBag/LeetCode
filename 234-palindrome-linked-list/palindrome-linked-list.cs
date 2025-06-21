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
    public bool IsPalindrome(ListNode head) {
        if(head == null || head.next == null) {
            return true;
        }

        Stack<int> stk = new Stack<int>();
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null) {
            stk.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }

        if(fast != null && fast.next == null) {
            // stk.Pop();
            slow = slow.next;
        }

        while(slow != null && stk.Count > 0) {
            if(stk.Peek() != slow.val) {
                return false;
            }

            stk.Pop();
            slow = slow.next;
        }

        return stk.Count == 0 ? true : false;
    }
}