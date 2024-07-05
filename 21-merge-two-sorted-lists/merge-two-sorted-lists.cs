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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) {
            return list2;
        }
        if(list2 == null) {
            return list1;
        }
        ListNode newHead = null;
        ListNode tmp = null;

        if(list1.val > list2.val) {
            newHead = list2;
            list2 = list2.next;
        } else {
            newHead = list1;
            list1 = list1.next;
        }

        tmp = newHead;

        while(list1 != null && list2 != null) {
            if(list1.val > list2.val) {
                tmp.next = list2;
                list2 = list2.next;
            } else {
                tmp.next = list1;
                list1 = list1.next;
            }
            
            tmp = tmp.next;
        }

        tmp.next = list1 == null ? list2 : list1;

        return newHead;
    }
}