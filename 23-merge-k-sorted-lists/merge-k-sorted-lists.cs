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
        if(lists.Count() <= 0) {
            return null;
        }

        if(lists.Count() == 1) {
            return lists[0];
        }

        while(lists.Count() > 1) {
            List<ListNode> mergedLists = new List<ListNode>();
            for(int i = 0; i < lists.Count(); i+= 2) {
                var l1 = lists[i];
                var l2 = i < lists.Count() - 1 ? lists[i + 1] : null;
                mergedLists.Add(MergeList(l1, l2));
            }

            lists = mergedLists.ToArray();
        }
        

        return lists[0];
    }

    private ListNode MergeList(ListNode l1, ListNode l2) {
        if(l1 == null) {
            return l2;
        }
        if(l2 == null) {
            return l1;
        }

        ListNode head = null;
        if(l1.val < l2.val) {
            head = l1;
            l1 = l1.next;
        } else {
            head = l2;
            l2 = l2.next;
        }

        ListNode tmp = head;
        while(l1 != null && l2 != null) {
            if(l1.val < l2.val) {
                tmp.next = l1;
                l1 = l1.next;
            } else {
                tmp.next = l2;
                l2 = l2.next;
            }

            tmp = tmp.next;
        }

        if(l1 == null) {
            tmp.next = l2;
        } else {
            tmp.next = l1;
        }

        return head;
    }
}