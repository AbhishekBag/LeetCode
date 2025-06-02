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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res = new();
        ListNode tmp = res;
        int carry = 0;

        // l1 = [9,9,9,9,9,9,9]
        // l2 = [9,9,9,9]
        while(l1 != null || l2 != null) {
            int sum = carry;
            if(l1 != null) {
                // Console.WriteLine($"l1.val: {l1.val}");
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null) {
                // Console.WriteLine($"l2.val: {l2.val}");
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            sum = sum % 10;

            tmp.val = sum;

            // Console.WriteLine($"carry: {carry}; sum digit: {sum}");

            if(l1 != null || l2 != null) {
                tmp.next = new ListNode();
                tmp = tmp.next;
            }
        }

        if(carry != 0) {
            tmp.next = new ListNode();
            tmp = tmp.next;
            tmp.val = carry;
        }

        return res;
    }
}