namespace _2._Add_Two_Numbers
{
    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode? p = l1, q = l2, current = head;
            int carry = 0;

            while (p != null || q != null)
            {
                int v1 = (p != null) ? p.Value : 0;
                int v2 = (q != null) ? q.Value : 0;
                int sum = carry + v1 + v2;
                carry = sum / 10;

                current.Next = new ListNode(sum % 10);
                current = current.Next;

                if (p != null) p = p.Next;
                if (q != null) q = q.Next;
            }

            if (carry > 0)
            {
                current.Next = new ListNode(carry);
            }

            return head.Next;
        }
    }
}
