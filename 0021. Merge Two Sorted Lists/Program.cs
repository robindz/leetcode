using _0021._Merge_Two_Sorted_Lists;
using Xunit;

var list1Node3 = new ListNode(4);
var list1Node2 = new ListNode(2, list1Node3);
var list1Node1 = new ListNode(1, list1Node2);

var list2Node3 = new ListNode(4);
var list2Node2 = new ListNode(3, list2Node3);
var list2Node1 = new ListNode(1, list2Node2);

var mergedList = Solution.MergeTwoLists(list1Node1, list2Node1);

int[] order = new int[] { 1, 1, 2, 3, 4, 4 };
for (int i = 0; i < order.Length; i++)
{
    Assert.Equal(order[i], mergedList.val);
    mergedList = mergedList.next;
}

Console.ReadKey();