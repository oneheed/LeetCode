// See https://aka.ms/new-console-template for more information
using LeetCode.Core;

var solution = new Solution();

var node = new ListNode(5, new(1, new(9)));
var head = new ListNode(4, node);
solution.DeleteNode(node);
Console.WriteLine(head.ToString()); // [4,1,9]


var node1 = new ListNode(1, new(9));
var head2 = new ListNode(4, new(5, node1));
solution.DeleteNode(node1);
Console.WriteLine(head2.ToString()); // [4,5,9]

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}