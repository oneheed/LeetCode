// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var node = new ListNode(1, new(2, new(3, new(4, new(5)))));
var n = 2;
var result = solution.RemoveNthFromEnd(node, n);
Console.WriteLine(result?.ToString()); // [1,2,3,5]

var node1 = new ListNode(1);
var n1 = 1;
var result1 = solution.RemoveNthFromEnd(node1, n1);
Console.WriteLine(result1?.ToString()); // []

var node2 = new ListNode(1, new(2));
var n2 = 1;
var result2 = solution.RemoveNthFromEnd(node2, n2);
Console.WriteLine(result2?.ToString()); // [1]

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
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var size = 0;
        for (var i = head; i != null; i = i.next)
            size++;

        size -= n;

        var cur = head;
        for (var i = 0; i < size - 1; i++)
            cur = cur.next;

        if (size == 0)
            return head.next;

        cur.next = cur.next.next;

        return head;
    }

    public ListNode RemoveNthFromEndHelper(ListNode head, ref int n)
    {
        if (head == null)
            return null;

        head.next = RemoveNthFromEndHelper(head.next, ref n);

        n--;

        if (n == 0)
        {
            return head.next;
        }


        return head;
    }
}