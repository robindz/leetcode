using _0019._Remove_Nth_Node_From_End_of_List;

var node5 = new ListNode(5);
var node4 = new ListNode(4, node5);
var node3 = new ListNode(3, node4);
var node2 = new ListNode(2, node3);
var node1 = new ListNode(1, node2);
var list = Solution.RemoveNthFromEnd(node1, 2);

Console.ReadKey();