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
    public ListNode RemoveNodes(ListNode head) {
        List<int> headList = new();
        ListNode currentNode = head;
        while (currentNode != null)
        {
            headList.Add(currentNode.val);
            currentNode = currentNode.next;
        }

        ListNode modifiedHead = new ListNode(headList.Last());
        for (int i = headList.Count - 2; i >= 0; i--)
        {
            if (headList[i] >= modifiedHead.val)
            {
                modifiedHead = new ListNode(headList[i], modifiedHead);
            }
        }

        return modifiedHead;
    }
}
