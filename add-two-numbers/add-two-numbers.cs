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
        var endvar = new ListNode(-1);
            var start = endvar;
            var overflow = 0;

            while (l1 != null || l2 != null)
            {
                var l1Value = l1 == null ? 0 : l1.val;
                var l2Value = l2 == null ? 0 : l2.val;

                var newNode = new ListNode((l1Value + l2Value + overflow)%10);
                start.next = newNode;
                start = start.next;

                overflow = (l1Value + l2Value + overflow) / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (overflow == 1)
            {
                var newNode = new ListNode(1);
                start.next = newNode;
            }

            return endvar.next;
    }
}