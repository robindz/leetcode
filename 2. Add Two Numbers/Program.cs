using _2._Add_Two_Numbers;
using Xunit;

ListNode l1 = new ListNode(2);
l1.Next = new ListNode(4);
l1.Next.Next = new ListNode(3);

ListNode l2 = new ListNode(5);
l2.Next = new ListNode(6);
l2.Next.Next = new ListNode(4);

ListNode result = Solution.AddTwoNumbers(l1, l2);

Assert.Equal(7, result.Value);
Assert.Equal(0, result?.Next?.Value);
Assert.Equal(8, result?.Next?.Next?.Value);

l1 = new ListNode(0);
l2 = new ListNode(0);

result = Solution.AddTwoNumbers(l1, l2);
Assert.Equal(0, result.Value);

Console.ReadKey();