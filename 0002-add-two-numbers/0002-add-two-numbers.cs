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
         if(l1 == null){
             return l2;
         }
         if(l2 == null){
             return l1;
         }
         if(l1 == null && l2 == null){
             return null;
         }
         int a = l1.val + l2.val;
         ListNode p = new ListNode(a % 10);
         p.next = AddTwoNumbers(l1.next, l2.next);
         if(a >= 10){
             p.next = AddTwoNumbers(p.next, new ListNode(1));
         }
         return p;

    }
}