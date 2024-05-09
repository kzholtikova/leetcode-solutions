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
    public ListNode DoubleIt(ListNode head) {
        head = new ListNode(0, head);
        ListNode curentNode = head;
        while (curentNode.next != null)
        {
            curentNode.next.val *= 2;
            if (curentNode.next.val > 9)
            {
                curentNode.val++;
                curentNode.next.val %= 10;
            }
            
            curentNode = curentNode.next;
        }
        
        return head.val == 0 ? head.next : head;
    }
}
