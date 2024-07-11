/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        HashSet<ListNode> collection = new HashSet<ListNode>();
        var temp = head;

        while(temp != null) {
            if(temp.next != null) {
                if(collection.Contains(temp.next)) {
                    return temp.next;
                }
            }

            collection.Add(temp);
            temp = temp.next;
        }

        return null;
    }
}