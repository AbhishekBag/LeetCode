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
        if(list1 == null && list2 == null) {
            return list1;
        }

        if(list1 == null) {
            return list2;
        }
        if(list2 == null) {
            return list1;
        }

        ListNode head = null, tmp = null;
        if(list1.val > list2.val) {
            Console.WriteLine($"Added {list2.val} from list2.");
            head = list2;
            list2 = list2.next;
        } else {
            // Console.WriteLine($"Added {list1.val} from list1.");
            head = list1;
            list1 = list1.next;
        }

        tmp = head;
        while(tmp != null) {
            if(list1 == null) {
                tmp.next = list2;
                break;
            }
            if(list2 == null) {
                tmp.next = list1;
                break;
            }
            if(list1.val > list2.val) {
                // Console.WriteLine($"Added {list2.val} from list2.");
                tmp.next = list2;
                list2 = list2.next;
            } else {
                // Console.WriteLine($"Added {list1.val} from list1.");
                tmp.next = list1;
                list1 = list1.next;
            }
            
            tmp = tmp.next;
        }

        return head;
    }
}